import java.util.*;

public class ArrayListTest {

    public static void main(String[] args) {

        // creating arrayList object by calling constructor
        //The purpose of using <Student> is specializing arraylist by informing which type of object it will hold
        ArrayList<Student> al = new ArrayList<Student>();

        // creating three Student objects
        Student s1 = new Student("ali", 1);
        Student s2 = new Student("saad", 2);
        Student s3 = new Student("raza", 3);

        // adding elements (Student objects) into arralylist
        al.add(s1);
        al.add(s2);
        al.add(s3);

        // checking whether arraylist is empty or not
        boolean b = al.isEmpty();
        if (b == true) {
            System.out.println("arraylist is empty");
        } else {
            int size = al.size();
            System.out.println("arraylist size: " + size);
        }

        // using loop to iterate. Loops starts from 0 to one
        // less than size
        for (int i = 0; i < al.size(); i++) {

            // retrieving object from arraylist
            Student s = (Student) al.get(i);

            // calling student class print method
            s.print();
        } // end for loop
    } // end main
} // end class