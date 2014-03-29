// File GridLayoutTest.java
import java.awt.*;
import javax.swing.*;

public class GridLayoutTest {

    JFrame myFrame;
    JButton b1, b2, b3, b4, b5;
//method used for setting layout of GUI
    public void initGUI() {
        myFrame = new JFrame("Grid Layout");
        Container c = myFrame.getContentPane();
// rows , cols
        c.setLayout(new GridLayout(3, 2));
        b1 = new JButton("Next Slide");
        b2 = new JButton("Previous Slide");
        b3 = new JButton("Back to Start");
        b4 = new JButton("Last Slide");
        b5 = new JButton("Exit");
        c.add(b1);
        c.add(b2);
        c.add(b3);
        c.add(b4);
        c.add(b5);
        myFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        myFrame.setSize(300, 150);
        myFrame.setVisible(true);
    } //end initGUI method
    public GridLayoutTest() { // default constructor
        initGUI();
    }

    public static void main(String args[]) {
        GridLayoutTest glTest = new GridLayoutTest();
    }
} // end of class