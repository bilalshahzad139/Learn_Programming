// step 1: importing required package
import java.net.*;
import java.io.*;
import javax.swing.*;

public class EchoServer {

    public static void main(String args[]) {
        try {
//step 2: create a server socket
            ServerSocket ss = new ServerSocket(2222);
            System.out.println("Server started...");
            /*
             * Loop back to the accept method of the server socket and wait for
             * a new connection request. So server will continuously listen for
             * requests
             */
            while (true) {
// step 3: wait for incoming connection
                Socket s = ss.accept();
                System.out.println("connection request recieved");
// step 4: Get I/O streams
                InputStream is = s.getInputStream();
                InputStreamReader isr = new InputStreamReader(is);
                BufferedReader br = new BufferedReader(isr);
                OutputStream os = s.getOutputStream();
                PrintWriter pw = new PrintWriter(os, true);

// step 5: Send / Receive message
// reading name sent by client
                String name = br.readLine();
// appending "hello" with the received name
                String msg = "Hello " + name + " from Server";
// sending back to client
                pw.println(msg);
// closing communication sockey
                s.close();
            } // end while
        } catch (Exception ex) {
            System.out.println(ex);
        }
    }
} // end class