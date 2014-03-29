// File Worker.java
public class Worker implements Runnable {

    private String job;

    public Worker(String j) {
        job = j;
    }

    public void run() {
        for (int i = 1; i <= 10; i++) {
            System.out.println(job + " = " + i);
        } // end for
    } // end run
} // end class