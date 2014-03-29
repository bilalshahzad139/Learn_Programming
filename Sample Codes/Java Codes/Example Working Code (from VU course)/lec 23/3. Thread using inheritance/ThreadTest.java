// File ThreadTest.java

public class ThreadTest {

    public static void main(String args[]) {
//instantiate three objects of Worker (Worker class is now
//becomes a Thread because it is inheriting from it)class
        Worker first = new Worker("first job");
        Worker second = new Worker("second job");
        Worker third = new Worker("third job");
//start threads to execute
        first.start();
        second.start();
        third.start();
    }//end main
} // end class