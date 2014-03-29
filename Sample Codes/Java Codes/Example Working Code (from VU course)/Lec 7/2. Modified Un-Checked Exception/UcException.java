// File UcException.java
public class UcException {

    public static void main(String args[]) {
        try {
            System.out.println(args[0]);
         catch (IndexOutOfBoundsExceptoin ex) {
            System.out.println("You forget to pass command line argument");
        }
    
}