// File Test.java
/* This class create Student class objects and demonstrates
 how to call various methods on objects
 */

public class Test {

    public static void main(String args[]) {

        // Make two student obejcts
        Student s1 = new Student("ali", 15);
        Student s2 = new Student(); //call to default costructor

        s1.print(); // display ali and 15
        s2.print(); // display not set and 100
        s2.setName("usman");
        s2.setRollNo(20);

        System.out.print("Student name:" + s2.getName());
        System.out.println(" rollNo:" + s2.getRollNo());
        System.out.println("calling copy constructor");
        Student s3 = new Student(s2); //call to copy constructor

        s2.print();
        s3.print();
        s3.setRollNo(-10); //Roll No of s3 would be set to 100
        s3.print();

        /*
         * NOTE: public vs. private A statement like "b.rollNo = 10;" will not
         * compile in a client of the Student class when rollNo is declared
         * protected or private
         */
    } //end of main
} //end of class