import java.lang.*;

// File ThreadTest.java
public class ThreadTest {

    public static void main(String args[]) {
//instantiate three objects
        Worker first = new Worker("first job");
        Worker second = new Worker("second job");
        Worker third = new Worker("third job");
//create three objects of Thread class & passing worker
//(runnable) to them
        Thread t1 = new Thread(first);
        Thread t2 = new Thread(second);
        Thread t3 = new Thread(third);
//start threads to execute
        t1.start();
        t2.start();
        t3.start();
    }//end main
} // end class