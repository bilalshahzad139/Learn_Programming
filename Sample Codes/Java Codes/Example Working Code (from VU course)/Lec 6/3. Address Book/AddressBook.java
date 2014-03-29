import javax.swing.*;
import java.util.*;

class AddressBook {

    ArrayList<PersonInfo> persons;
//constructor
    public AddressBook() {
        persons = new ArrayList<PersonInfo>();
    }
//add new person record to arraylist after taking input
    public void addPerson() {
        String name = JOptionPane.showInputDialog("Enter name");
        String add = JOptionPane.showInputDialog("Enter address");
        String pNum = JOptionPane.showInputDialog("Enter phone no");
//construt new person object
        PersonInfo p = new PersonInfo(name, add, pNum);
//add the above PersonInfo object to arraylist
        persons.add(p);
    }
//search person record by name by iterating over arraylist
    public void searchPerson(String n) {
        for (int i = 0; i < persons.size(); i++) {
            PersonInfo p = (PersonInfo) persons.get(i);
            if (n.equals(p.name)) {
                p.print();
            }
        } // end for
    } // end searchPerson
//delete person record by name by iterating over arraylist
    public void deletePerson(String n) {
        for (int i = 0; i < persons.size(); i++) {
            PersonInfo p = (PersonInfo) persons.get(i);
            if (n.equals(p.name)) {
                persons.remove(i);
            }
        }
    }
} // end class