// File GUITest.java
//Step 1: import packages
import java.awt.*;
import javax.swing.*;

public class GUITest {

    JFrame myFrame;
    JTextField tf;
    JButton b;
//method used for setting layout of GUI
    public void initGUI() {
//Step 2: setup the top level container
        myFrame = new JFrame();
//Step 3: Get the component area of top-level container
        Container c = myFrame.getContentPane();
//Step 4: Apply layouts
        c.setLayout(new FlowLayout());
//Step 5: create & add components
        JTextField tf = new JTextField(10);
        JButton b1 = new JButton("My Button");
        c.add(tf);
        c.add(b1);
//Step 6: set size of frame and make it visible
        myFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        myFrame.setSize(200, 150);
        myFrame.setVisible(true);
    } //end initGUI method
    public GUITest() { // default constructor
        initGUI();
    }

    public static void main(String args[]) {
        GUITest gui = new GUITest();
    }
} // end of class