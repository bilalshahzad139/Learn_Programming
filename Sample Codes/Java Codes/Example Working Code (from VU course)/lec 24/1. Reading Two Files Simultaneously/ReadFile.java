// File ReadFile.java
import java.io.*;

public class ReadFile implements Runnable {
//attribute used for name of file
    String fileName;
// param constructor
    public ReadFile(String fn) {
        fileName = fn;
    }
// overriding run method
// this method contains the code for file reading
    public void run() {
        try {
// connecting FileReader with attribute fileName
            FileReader fr = new FileReader(fileName);
            BufferedReader br = new BufferedReader(fr);
            String line = "";
// reading line by line data from file
// and displaying it on console
            line = br.readLine();
            while (line != null) {
                System.out.println(line);
                line = br.readLine();
            }
            fr.close();
            br.close();
        } catch (Exception e) {
            System.out.println(e);
        }
    } // end run() method
}