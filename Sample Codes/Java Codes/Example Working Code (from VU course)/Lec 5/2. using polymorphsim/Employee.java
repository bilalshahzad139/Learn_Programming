class Employee {

    protected int id;
    protected String name;

    //parameterized constructor
    public Employee(int id, String name) {
        this.id = id;
        this.name = name;
    }

    //default constructor
    public Employee() {

        // calling parameterized constructor of same (Employee)
        // class by using keyword this
        this(10, "not set");
    }

    //setters
    public void setId(int id) {
        this.id = id;
    }

    public void setName(String name) {
        this.name = name;
    }

    //getters
    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    // displaying employee object on console
    public void display() {
        System.out.println("in employee display method");
        System.out.println("Employee id:" + id + " name:" + name);
    }

    //overriding object’s class toString method
    public String toString() {
        System.out.println("in employee toString method");
        return "id:" + id + "name:" + name;
    }
}//end class