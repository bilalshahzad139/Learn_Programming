// importing required packages
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class AnimTest implements ActionListener {

    JFrame f;
    MyPanel p;
// used to control the direction of ball
    int x, y;

    public AnimTest() {
        f = new JFrame();
        Container c = f.getContentPane();
        c.setLayout(new BorderLayout());
        x = 5;
        y = 3;
        p = new MyPanel();
        c.add(p);
        f.setSize(400, 400);
        f.setVisible(true);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
// creating a Timer class object, used for firing
// one or more action events after a specified delay
// Timer class constructor requires time in
// milliseconds and object of class that handles
// action events
        Timer t = new Timer(5, this);
// starts the timer, causing it to start sending
// action events to listeners
        t.start();
    } // end constructor
// event handler method
    public void actionPerformed(ActionEvent ae) {
// if ball reached to maximum width of frame minus
// 40 since diameter of ball is 40 then change the
// X-direction of ball
        if (f.getWidth() - 40 == p.mX) {
            x = -5;
        }

// if ball reached to maximum height of frame
// minus 40 then change the Y-direction of ball
        if (f.getHeight() - 40 == p.mY) {
            y = -3;
        }
// if ball reached to min. of width of frame,
// change the X-direction of ball
        if (p.mX == 0) {
            x = 5;
        }
// if ball reached to min. of height of frame,
// change the Y-direction of ball
        if (p.mY == 0) {
            y = 3;
        }
// Assign x,y direction to MyPanel’s mX & mY
        p.mX += x;
        p.mY += y;
// call to repaint() method so that ball is drawn on
// new locations
        p.repaint();
    } // end actionPerformed() method
// main method
    public static void main(String args[]) {
        AnimTest at = new AnimTest();
    }
} // end AnimTest class