// File WriteFileEx.java
import java.io.*;
public class WriteFileEx {
public static void main (String args[ ]) {
FileWriter fw = null;
PrintWriter pw = null;
try {
// attaching node stream with data source
// if file does not exist, it automatically creates it
fw = new FileWriter ("output.txt");
// attatching filter stream over node stream
pw = new PrintWriter(fw);
String s1 = "Hello World";
String s2 = "Web Design and Development";
// writing first string to file
pw.println(s1);
// writing second string to file
pw.println(s2);
// flushing stream
pw.flush();
// closing streams
pw.close();
fw.close();
}catch(IOException ioex){
System.out.println(ioex);
}
} // end main
} // end class