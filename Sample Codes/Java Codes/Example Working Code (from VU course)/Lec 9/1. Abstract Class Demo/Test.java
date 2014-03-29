
public class Test {

    public static void main(String args[]) {
//can only create references of A.C.
        Shape s = null;
//Shape s1 = new Shape(); //cannot instantiate
//abstract class reference can point to concrete subclass
        s = new Circle();
        s.calculateArea();
    }
}//end of class