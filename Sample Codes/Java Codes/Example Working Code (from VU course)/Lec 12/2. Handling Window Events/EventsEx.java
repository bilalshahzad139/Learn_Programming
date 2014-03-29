import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class EventsEx implements MouseMotionListener, WindowListener {

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
        // registring mouse event handler with generator
        frame.addMouseMotionListener(this);

        // registering window handler with generator
        frame.addWindowListener(this);

        frame.setSize(350, 350);
        frame.setVisible(true);
    } // end initGUI method
    //default constructor

    public EventsEx() {
        initGUI();
    }
// MouseMotionListener event hadler handling dragging

    public void mouseDragged(MouseEvent me) {
        int x = me.getX();
        int y = me.getY();
        coordinates.setText("Dragged at [" + x + "," + y + "]");
    }
// MouseMotionListener event handler handling motion

    public void mouseMoved(MouseEvent me) {
        int x = me.getX();
        int y = me.getY();
        coordinates.setText("Moved at [" + x + "," + y + "]");
    }

    // window listener event handler
    public void windowActivated(WindowEvent we) {
    }

    public void windowClosed(WindowEvent we) {
    }

    public void windowClosing(WindowEvent we) {
        JOptionPane.showMessageDialog(null, "Good Bye");
        System.exit(0);
    }

    public void windowDeactivated(WindowEvent we) {
    }

    public void windowDeiconified(WindowEvent we) {
    }

    public void windowIconified(WindowEvent we) {
    }

    public void windowOpened(WindowEvent we) {
    }

    public static void main(String args[]) {
        EventsEx ex = new EventsEx();
    }
} // end class