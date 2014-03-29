// File Test.java
public class Test {

    public static void main(String args[]) {
// creating ReadFile objects by passing file names to them
        ReadFile first = new ReadFile("first.txt");
        ReadFile second = new ReadFile("second.txt");
// Instantiating thread objects and passing
// runnable (ReadFile) objects to them
        Thread t1 = new Thread(first);
        Thread t2 = new Thread(second);
// starting threads that cause threads to read data from
// two different files simultaneously
        t1.start();
        t2.start();
    }
}