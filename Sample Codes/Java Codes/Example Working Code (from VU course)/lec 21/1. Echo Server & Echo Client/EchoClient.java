// step 1: importing required package
import java.net.*;
import java.io.*;
import javax.swing.*;

public class EchoClient {

    public static void main(String args[]) {
        try {
//step 2: create a communication socket
// if your server will run on the same machine then
//you can pass "localhost" as server address 
/*
             * Notice that port no is similar to one passed while creating
             * server socket 
server
             */
            Socket s = new Socket("localhost", 2222);
// step 3: Get I/O streams
            InputStream is = s.getInputStream();
            InputStreamReader isr = new InputStreamReader(is);
            BufferedReader br = new BufferedReader(isr);
            OutputStream os = s.getOutputStream();
            PrintWriter pw = new PrintWriter(os, true);
// step 4: Send / Receive message
// asking use to enter his/her name
            String msg = JOptionPane.showInputDialog(
                    "Enter your name");
// sending name to server
            pw.println(msg);
// reading message (name appended with hello) from
// server
            msg = br.readLine();
// displaying received message
            JOptionPane.showMessageDialog(null, msg);
// closing communication socket
            s.close();
        } catch (Exception ex) {
            System.out.println(ex);
        }
    }
} // end class