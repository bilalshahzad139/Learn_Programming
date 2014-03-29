import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class EventsEx implements MouseMotionListener {

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
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
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

    public static void main(String args[]) {
        EventsEx ex = new EventsEx();
    }
} // end class