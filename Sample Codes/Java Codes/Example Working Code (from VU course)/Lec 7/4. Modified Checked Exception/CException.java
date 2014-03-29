// File CException.java
import java.io.*;

public class CException {

    public static void main(String args[]) {
        try {
            FileReader fr = new FileReader("input.txt");
            BufferedReader br = new BufferedReader(fr);
//read the line form file
            String line = br.readLine();
            System.out.println(line);
        } catch (IOException ex) {
            System.out.println(ex);
        }
    }
}