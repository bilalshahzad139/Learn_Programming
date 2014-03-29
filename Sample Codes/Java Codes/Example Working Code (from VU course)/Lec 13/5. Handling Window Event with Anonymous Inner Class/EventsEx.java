import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class EventsEx extends WindowAdapter {

    JFrame frame;
    JLabel coordinates;
// setting layout

    public void initGUI() {
// creating event generator
        frame = new JFrame();
        Container cont = frame.getContentPane();
        cont.setLayout(new BorderLayout());
        coordinates = new JLabel();
        cont.add(coordinates, BorderLayout.NORTH);
// registering event handler (anonymous inner class)
// with generator by using
        frame.addWindowListener(
                new WindowAdapter() {

                    public void windowClosing(WindowEvent we) {
                        JOptionPane.showMessageDialog(null, "Good Bye");
                        System.exit(0);
                    } // end window closing
                } // end WindowAdapter
                ); // end of addWindowListener
        frame.setSize(350, 350);
        frame.setVisible(true);
    } // end initGUI method
//default constructor

    public EventsEx() {
        initGUI();
    }

    public static void main(String args[]) {
        EventsEx ex = new EventsEx();
    }
} // end class