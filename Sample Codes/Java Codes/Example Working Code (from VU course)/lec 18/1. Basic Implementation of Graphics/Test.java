// importing required packages
import javax.swing.*;
import java.awt.*;

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
    } // end constructor
// main method
    public static void main(String args[]) {
        Test t = new Test();
    }
} // end Test class