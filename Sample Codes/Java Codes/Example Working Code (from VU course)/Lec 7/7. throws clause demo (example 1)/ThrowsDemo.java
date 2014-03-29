
// File ThrowsDemo.java
import java.io.*;

public class ThrowsDemo {
// contains file reading code
    public static void method2() {
        try {
            FileReader fr = new FileReader("strings.txt");
            BufferedReader br = new BufferedReader(fr);
//read the line form file
            String s = br.readLine();
            System.out.println(s);
        } catch (IOException ioEx) {
            ioEx.printStackTrace();
        }
    }// end method 2
//only calling method2
    public static void method1() {
        method2();
    }

    public static void main(String args[]) {
        ThrowsDemo.method1();
    }
}