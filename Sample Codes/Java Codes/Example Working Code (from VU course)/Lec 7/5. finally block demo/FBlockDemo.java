// File FBlockDemo.java
import java.io.*;

public class FBlockDemo {

    public static void main(String args[]) {
        try {
            FileReader fr = new FileReader("strings.txt");
            BufferedReader br = new BufferedReader(fr);
//read the line form file
            String line = br.readLine();
            System.out.println(line);
        } catch (IOException ex) {
            System.out.println(ex);
        } finally {
            System.out.println("finally block always execute");
        }
    }
}