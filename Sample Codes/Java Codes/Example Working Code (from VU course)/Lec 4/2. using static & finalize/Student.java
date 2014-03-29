// File Student.java
public class Student {

    private String name;
    private int rollNo;
    private static int countStudents = 0;

    // Standard Setters
    public void setName(String name) {
        this.name = name;
    }

    // Note the masking of class level variable rollNo
    public void setRollNo(int rollNo) {
        if (rollNo > 0) {
            this.rollNo = rollNo;
        } else {
            this.rollNo = 100;
        }
    }

    // Standard Getters
    public String getName() {
        return name;
    }

    public int getRollNo() {
        return rollNo;
    }

    // gettter of static countStudents variable
    public static int getCountStudents() {
        return countStudents;
    }

    // Default Constructor
    public Student() {
        name = "not set";
        rollNo = 100;
        countStudents += 1;
    }

    // parameterized Constructor for a new student
    public Student(String name, int rollNo) {
        setName(name); //call to setter of name
        setRollNo(rollNo); //call to setter of rollNo
        countStudents += 1;
    }

    // Copy Constructor for a new student
    public Student(Student s) {
        name = s.name;
        rollNo = s.rollNo;
        countStudents += 1;
    }

    // method used to display method on console
    public void print() {
        System.out.print("Student name: " + name);
        System.out.println(", roll no: " + rollNo);
    }

    // overriding toString method of java.lang.Object class
    public String toString() {
        return "name: " + name + " RollNo: " + rollNo;
    }

    // overriding finalize method of Object class
    public void finalize() {
        countStudents -= 1;
    }
} // end of class