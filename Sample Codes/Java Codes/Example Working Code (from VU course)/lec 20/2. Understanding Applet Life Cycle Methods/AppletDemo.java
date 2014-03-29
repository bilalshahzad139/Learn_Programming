// File AppletDemo.java
//step 1: importing required packages
import java.awt.*;
import javax.swing.*;
// extending class from JApplet so that our class also becomes an
//applet
public class AppletDemo extends JApplet {
// overriding init method
    public void init() {
        System.out.println("init() called");
    }
// overriding start method
    public void start() {
        System.out.println("start() called");
    }
// overriding paint method
    public void paint(Graphics g) {
        System.out.println("paint() called");
    }
// overriding stop method
    public void stop() {
        System.out.println("stop() called");
    }
// overriding destroy method
    public void destroy() {
        System.out.println("destroy() called");
    }
} // end class