// File JoinEx.java
public class JoinEx {

    public static void main(String args[]) {
        Worker first = new Worker("first job");
        Worker second = new Worker("second job");
        Thread t1 = new Thread(first);
        Thread t2 = new Thread(second);
        System.out.println("Starting...");
// starting threads
        t1.start();
        t2.start();
// The current running thread (main) blocks until both
//workers have finished
        try {
            t1.join();
            t2.join();
        } catch (Exception ex) {
            System.out.println(ex);
        }
        System.out.println("All done ");
    } // end main
}