// File HelloApplet.java
//step 1: importing required packages
import java.awt.*;
import javax.swing.*;
// extending class from JApplet so that our class also becomes an
//applet
public class HelloApplet extends JApplet {
// overriding paint method
    public void paint(Graphics g) {
// write code here u want to display & draw by using
// Graphics object
        g.drawString("Hello World", 30, 30);
    }
} // end class