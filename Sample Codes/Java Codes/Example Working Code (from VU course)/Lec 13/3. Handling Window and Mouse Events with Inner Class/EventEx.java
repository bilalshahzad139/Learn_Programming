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
        WindowHandler whandler = new WindowHandler();
        frame.addWindowListener(whandler);
        /*
         * Creating an object of the class which is handling our MouseMotion
         * events & registering it with generator
         */
        MouseHandler mhandler = new MouseHandler();
        frame.addMouseMotionListener(mhandler);
        frame.setSize(350, 350);
        frame.setVisible(true);
    }
//default constructor

    public EventEx() {
        initGUI();
    }
    /*
     * Inner class implementation of WindowAdapter. Outer class is free to
     * inherit from any other class.
     */

    private class WindowHandler extends WindowAdapter {
// Event Handler for WindowListener

        public void windowClosing(WindowEvent we) {
            JOptionPane.showMessageDialog(null, "Good Bye");
            System.exit(0);
        }
    } // end of WindowHandler
//Inner class implementation of MouseMotionAdapter

    private class MouseHandler extends MouseMotionAdapter {
// Event Handler for mouse motion events

        public void mouseMoved(MouseEvent me) {
            int x = me.getX();
            int y = me.getY();
            coordinates.setText("Moved at [" + x + "," + y + "]");
        }
    } // end of MouseHandler

    public static void main(String args[]) {
        EventEx e = new EventEx();
    }
} // end class