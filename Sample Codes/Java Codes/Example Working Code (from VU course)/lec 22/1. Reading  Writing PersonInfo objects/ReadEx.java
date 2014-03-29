import java.io.*;

public class ReadEx {

    public static void main(String args[]) {
        try {
// attaching FileInput stream with "ali.dat"
            FileInputStream fis = new FileInputStream("ali.dat");
// attaching FileInput stream over ObjectInput stream
            ObjectInputStream in = new ObjectInputStream(fis);
//de-serialization
// reading object from 'ali.dat'
            PersonInfo pRead = (PersonInfo) in.readObject();
// calling printPersonInfo method to confirm that
// object contains same set of values before
// serializatoion
            pRead.printPersonInfo();
// closing streams
            in.close();
            fis.close();
        } catch (Exception ex) {
            System.out.println(ex);
        }
    }
} // end class