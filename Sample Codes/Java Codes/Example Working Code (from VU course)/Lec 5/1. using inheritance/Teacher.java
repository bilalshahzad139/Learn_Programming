class Teacher extends Employee {

    private String qual;

    //default constructor
    public Teacher() {

        //implicit call to superclass default construct
        qual = "";
    }

    //parameterized constructor
    public Teacher(int i, String n, String q) {

        //call to superclass param const must be first line
        super(i, n);
        qual = q;
    }

    //setter
    public void setQual(String qual) {
        this.qual = qual;
    }

    //getter
    public String getQual() {
        return qual;
    }

    //overriding display method of Employee class
    public void display() {
        System.out.println("in teacher's display method");
        super.display(); //call to superclass display method
        System.out.println("Teacher qualification:" + qual);
    }

    //overriding toString method of Employee class
    public String toString() {
        System.out.println("in teacher's toString method");
        String emp = super.toString();
        return emp + " qualification:" + qual;
    }
}//end class