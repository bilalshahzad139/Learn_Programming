// File YieldEx.java
public class YieldEx {

    public static void main(String args[]) {
// Creating Worker objects
        Worker first = new Worker("first job");
        Worker second = new Worker("second job");
// Instantiating thread class objects
        Thread t1 = new Thread(first);
        Thread t2 = new Thread(second);
// starting thread
        t1.start();
        t2.start();
    }
} // end class