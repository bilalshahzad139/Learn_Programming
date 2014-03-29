// importing required packages
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Test {

    JFrame f;
// declaring Reference of MyPanel class
    MyPanel p;
// parameter less constructor
    public Test() {
        f = new JFrame();
        Container c = f.getContentPane();
        c.setLayout(new BorderLayout());
// instantiating reference
        p = new MyPanel();
// adding MyPanel into container
        c.add(p);
        f.setSize(400, 400);
        f.setVisible(true);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
// creating inner class object
        Handler h = new Handler();
// registering MyPanel to handle events
        p.addMouseMotionListener(h);
    } // end constructor
// inner class used for handling events
    public class Handler extends MouseMotionAdapter {
// capturing mouse dagged events
        public void mouseDragged(MouseEvent me) {
// getting the X-Position of mouse and assigning
// value to instance variable mX of MyPanel class
            p.mX = me.getX();
// getting the Y-Position of mouse and assigning
// value to instance variable mX of MyPanel class
            p.mY = me.getY();
// call to repaint causes rectangle to be drawn on
// new location
            p.repaint();
        } // end mouseDragged
    } // end Handler class
// main method
    public static void main(String args[]) {
        Test t = new Test();
    }
} // end Test class