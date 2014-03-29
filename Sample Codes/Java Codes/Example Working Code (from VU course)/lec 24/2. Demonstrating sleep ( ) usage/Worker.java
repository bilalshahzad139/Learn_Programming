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
            try {
                Thread.sleep(100); // go to sleep for 100 ms
            } catch (Exception ex) {
                System.out.println(ex);
            }
            System.out.println(job + " = " + i);
        } // end for
    } // end run
} // end class