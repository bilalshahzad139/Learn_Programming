// File JavaAnim.java
//step 1: importing required packages
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class JavaAnim extends JApplet implements ActionListener {
// used to count how many times paint is called
    int clearCounter;
// declaring Timer reference
    Timer t;
// overriding init method, used to initialize variables
    public void init() {
        setBackground(Color.black);
        clearCounter = 0;
        Timer t = new Timer(1000, this);
        t.start();
    }

// overriding paint method – discussed above
    public void paint(Graphics g) {
        clearCounter++;
        Graphics2D g2 = (Graphics2D) g;
        if (clearCounter == 10) {
            g2.clearRect(0, 0, 1000, 700);
            clearCounter = 0;
        }
        for (int i = 1; i <= 40; i++) {
            Color c = chooseColor();
            g2.setColor(c);
            Font f = chooseFont();
            g2.setFont(f);
            drawJava(g2);
        }
    }
// overriding actionPerformed()of ActionListener interface
// called by Timer object
    public void actionPerformed(ActionEvent ae) {
        repaint();
    }
// chooseColor method – discussed above
    public Color chooseColor() {
        int r = (int) (Math.random() * 255);
        int g = (int) (Math.random() * 255);
        int b = (int) (Math.random() * 255);
        Color c = new Color(r, g, b);
        return c;
    }

// chooseFont method – discussed above
    public Font chooseFont() {
        int fontChoice = (int) (Math.random() * 4) + 1;
        Font f = null;
        switch (fontChoice) {
            case 1:
                f = new Font("Serif", Font.BOLD + Font.ITALIC, 20);
                break;
            case 2:
                f = new Font("SansSerif", Font.PLAIN, 17);
                break;
            case 3:
                f = new Font("Monospaced", Font.ITALIC, 23);
                break;
            case 4:
                f = new Font("Dialog", Font.ITALIC, 30);
                break;
        }
        return f;
    }
// drawJava() method – discussed above
    public void drawJava(Graphics2D g2) {
        int x = (int) (Math.random() * 1000);
        int y = (int) (Math.random() * 700);
        g2.drawString("java", x, y);
    }
} // end class