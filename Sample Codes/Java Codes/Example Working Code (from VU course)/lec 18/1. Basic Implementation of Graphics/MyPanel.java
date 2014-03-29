// importing required packages
import javax.swing.*;
import java.awt.*;
// extending class from JPanel
public class MyPanel extends JPanel {
// overriding paintComponent method
    public void paintComponent(Graphics g) {
// erasing behaviour – this will clear all the
// previous painting
        super.paintComponent(g);
// Down casting Graphics object to Graphics2D
        Graphics2D g2 = (Graphics2D) g;
// drawing rectanle
        g2.drawRect(20, 20, 20, 20);
// changing the color to blue
        g2.setColor(Color.blue);
// drawing filled oval with color i.e. blue
        g2.fillOval(50, 50, 20, 20);
// drawing string
        g2.drawString("Hello World", 120, 50);
    }// end paintComponent
} // end MyPanel class