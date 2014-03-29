// File BorderLayoutTest.java
import java.awt.*;
import javax.swing.*;

public class BorderLayoutTest {

    JFrame myFrame;
    JButton b1, b2, b3, b4, b5;
//method used for setting layout of GUI
    public void initGUI() {
        myFrame = new JFrame("Border Layout");
        Container c = myFrame.getContentPane();
        c.setLayout(new BorderLayout());
        b1 = new JButton("Next Slide");
        b2 = new JButton("Previous Slide");
        b3 = new JButton("Back to Start");
        b4 = new JButton("Last Slide");
        b5 = new JButton("Exit");
        c.add(b1, BorderLayout.NORTH);
        c.add(b2, BorderLayout.SOUTH);
        c.add(b3, BorderLayout.EAST);
        c.add(b4, BorderLayout.WEST);
        c.add(b5, BorderLayout.CENTER);
        myFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        myFrame.setSize(300, 150);
        myFrame.setVisible(true);
    } //end initGUI method
    public BorderLayoutTest() { // default constructor
        initGUI();
    }

    public static void main(String args[]) {
        BorderLayoutTest glTest = new BorderLayoutTest();
    }
} // end of class