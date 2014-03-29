
import javax.swing.*;

class PersonInfo {

    String name;
    String address;
    String phoneNum;

    //parameterized constructor
    public PersonInfo(String n, String a, String p) {
        name = n;
        address = a;
        phoneNum = p;
    }

    //method for displaying person record on GUI
    public void print() {
        JOptionPane.showMessageDialog(null, "name: " + name + "address:" + address + "phone no:" + phoneNum);
    }
}