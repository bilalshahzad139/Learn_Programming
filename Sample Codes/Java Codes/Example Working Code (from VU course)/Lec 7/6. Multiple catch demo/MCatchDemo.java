import java.io.*;

public class MutliCatch {

    public static void main(String args[]) {

        try {
            FileReader fr = new FileReader("input.txt");
            BufferedReader br = new BufferedReader(fr);
        } catch (Exception Ex) {
            System.out.println(Ex);
        } catch (IOException ioEx) {
            System.out.println(ioEx);
        }
    }
}