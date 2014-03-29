import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class EventEx {

    JFrame frame;
    JLabel coordinates;
// setting layout
    public void initGUI() {
        frame = new JFrame();
        Container cont = frame.getContentPane();
        cont.setLayout(new BorderLayout());
        coordinates = new JLabel();
        cont.add(coordinates, BorderLayout.NORTH);
        /*
         * Creating an object of the class which is handling our window events
         * and registering it with generator
         */
        WindowHandler handler = new WindowHandler();
        frame.addWindowListener(handler);
        frame.setSize(350, 350);
        frame.setVisible(true);
    } // end initGUI
//default constructor

    public EventEx() {
        initGUI();
    }
    /*
     * Inner class implementation of window adapter. Outer class is free to
     * inherit from any other class.
     */

    private class WindowHandler extends WindowAdapter {
// Event Handler for WindowListener

        public void windowClosing(WindowEvent we) {
            JOptionPane.showMessageDialog(null, "Good Bye");
            System.exit(0);
        }
    } // end of WindowHandler class

    public static void main(String args[]) {
        EventEx e = new EventEx();
    }
} // end class