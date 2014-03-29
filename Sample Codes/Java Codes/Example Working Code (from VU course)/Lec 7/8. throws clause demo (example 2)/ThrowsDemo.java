// File ThrowsDemo.java
import java.io.*;

public class ThrowsDemo {
// contains file reading code
    public static void method2() throws IOException {
        FileReader fr = new FileReader("strings.txt");
        BufferedReader br = new BufferedReader(fr);
//read the line form file
        String s = br.readLine();
        System.out.println(s);
    }// end method 2
// calling method2 & handling incoming exception
    public static void method1() {
        try {
            method2();
        } catch (IOException ioEx) {
            ioEx.printStackTrace();
        }
    }

    public static void main(String args[]) {
        ThrowsDemo.method1();
    }
}