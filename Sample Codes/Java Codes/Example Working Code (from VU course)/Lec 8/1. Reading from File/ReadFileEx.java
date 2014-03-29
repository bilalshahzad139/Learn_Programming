// File ReadFileEx.java
import java.io.*;
public class ReadFileEx {
public static void main (String args[ ]) {
FileReader fr = null;
BufferedReader br = null;
try {
// attaching node stream with data source
fr = new FileReader("input.txt");
// attatching filter stream over node stream
br = new BufferedReader(fr);
// reading first line from file
String line = br.readLine();
// printing and reading remaining lines
while (line != null){
System.out.println(line);
line = br.readLine();
}
// closing streams
br.close();
fr.close();
}catch(IOException ioex){
System.out.println(ioex);
}
} // end main
} // end class