import javax.swing.*;
import java.awt.*;
// extending class from JPanel
public class MyPanel extends JPanel {
// variables used to draw rectangles at different
//locations
    int mX = 20;
    int mY = 20;
// overriding paintComponent method
    public void paintComponent(Graphics g) {
// erasing behaviour – this will clear all the
// previous painting
        super.paintComponent(g);
// Down casting Graphics object to Graphics2D
        Graphics2D g2 = (Graphics2D) g;
// changing the color to blue
        g2.setColor(Color.blue);
// drawing filled oval with color i.e. blue
// using instance variables
        g2.fillRect(mX, mY, 20, 20);
    }// end paintComponent
} // end MyPanel class