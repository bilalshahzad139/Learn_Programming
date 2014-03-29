// File Worker.java
public class Worker implements Runnable {

    private String job;
//Constructor of Worker class
    public Worker(String j) {
        job = j;
    }
//Implement run() method of Runnable interface
    public void run() {
        for (int i = 1; i <= 10; i++) {
// giving chance to a thread to execute of same priority
            Thread.yield();
            System.out.println(job + " = " + i);
        } // end for
    } // end run
} // end class