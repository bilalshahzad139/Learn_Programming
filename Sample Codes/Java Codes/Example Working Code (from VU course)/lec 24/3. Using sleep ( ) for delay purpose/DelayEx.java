// File DelayEx.java
public class DelayEx {

    public static void main(String args[]) {
        System.out.println("main thread going to sleep");
        try {
// the main thread will go to sleep causing delay
            Thread.sleep(100);
        } catch (Exception ex) {
            System.out.println(ex);
        }
        System.out.println("main thread coming out of sleep");
    } // end main()
}