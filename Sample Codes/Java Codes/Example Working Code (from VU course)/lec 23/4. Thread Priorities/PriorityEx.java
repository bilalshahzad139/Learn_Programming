// File PriorityEx.java
public class PriorityEx {

    public static void main(String args[]) {
//instantiate two objects
        Worker first = new Worker("first job");
        Worker second = new Worker("second job");
//create two objects
        Thread t1 = new Thread(first);
        Thread t2 = new Thread(second);
//set thread priorities
        t1.setPriority(Thread.MIN_PRIORITY);
        t2.setPriority(Thread.MAX_PRIORITY);
//start threads to execute
        t1.start();
        t2.start();
    }//end main
} // end class