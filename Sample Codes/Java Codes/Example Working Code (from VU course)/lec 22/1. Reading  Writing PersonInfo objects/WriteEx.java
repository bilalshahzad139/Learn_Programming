import java.io.*;

public class WriteEx {

    public static void main(String args[]) {
        PersonInfo pWrite =
                new PersonInfo("ali", "defence", "9201211");
        try {
// attaching FileOutput stream with "ali.dat"
            FileOutputStream fos =
                    new FileOutputStream("ali.dat");
// attaching ObjectOutput stream over FileOutput
// stream
            ObjectOutputStream out =
                    new ObjectOutputStream(fos);
//serialization
// writing object to 'ali.dat'
            out.writeObject(pWrite);
// closing streams
            out.close();
            fos.close();
        } catch (Exception ex) {
            System.out.println(ex);
        }
    } // end main
} // end class