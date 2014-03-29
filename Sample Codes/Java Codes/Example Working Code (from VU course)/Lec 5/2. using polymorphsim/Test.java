class Test {

    public static void main(String args[]) {

        // Make employee references
        Employee ref1, ref2;

        // assign employee object to first employee reference
        ref1 = new Employee(89, "khurram ahmad");

        // is-a relationship, polymorphism
        ref2 = new Teacher(91, "ali raza", "phd");

        //call to Employee class display method
        ref1.display();

        //call to Teacher class display method
        ref2.display();

        // call to Employee class toString method
        System.out.println("Employee: " + ref1.toString());

        // call to Teacher class toString method
        System.out.println("Teacher: " + ref2.toString());
    } //end of main
}//end class