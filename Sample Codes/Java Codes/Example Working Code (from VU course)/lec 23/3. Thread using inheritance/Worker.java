// File Worker.java
public class Worker extends Thread {

    private String job;
//Constructor of Worker class
    public Worker(String j) {
        job = j;
    }
//Override run() method of Thread class
    public void run() {
        for (int i = 1; i <= 10; i++) {
            System.out.println(job + " = " + i);
        }
    }
} // end class