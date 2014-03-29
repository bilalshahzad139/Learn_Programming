import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

/*
 * Implementing the interface according to the type of the event, i.e. creating
 * event handler (first part of step 2 of our process)
 */
public class ActionEventTest implements ActionListener {

    JFrame frame;
    JButton hello;
// setting layout components

    public void initGUI() {
        frame = new JFrame();
        Container cont = frame.getContentPane();
        cont.setLayout(new FlowLayout());
//Creating event generator step-1 of our process
        hello = new JButton("Hello");
        /*
         * Registering event handler with event generator. Since event handler
         * is in same object that contains button, we have used this to pass the
         * reference.(step 3 of the process)
         */
        hello.addActionListener(this);
        cont.add(hello);

        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(150, 150);
        frame.setVisible(true);
    }
//constructor

    public ActionEventTest() {
        initGUI();
    }
    /*
     * Override actionPerformed method of ActionListener’s interfacemethod of
     * which will be called when event takes place (second part of step 2 of our
     * process)
     */

    public void actionPerformed(ActionEvent event) {
        JOptionPane.showMessageDialog(null, "Hello is pressed");
    }

    public static void main(String args[]) {
        ActionEventTest aeTest = new ActionEventTest();
    }
} // end class