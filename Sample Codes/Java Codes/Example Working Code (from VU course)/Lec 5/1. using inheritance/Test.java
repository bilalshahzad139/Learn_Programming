class Test {

    public static void main(String args[]) {
        System.out.println("making object of employee");
        Employee e = new Employee(89, "khurram ahmad");
        System.out.println("making object of teacher");
        Teacher t = new Teacher(91, "ali raza", "phd");
        e.display(); //call to Employee class display method
        t.display(); //call to Teacher class display method

        // calling employee class toString method explicitly
        System.out.println("Employee: " + e.toString());

        // calling teacher class toString implicitly
        System.out.println("Teacher: " + t);
    } //end of main
}//end class