public class Circle extends Shape {

    private int x, y;
    private int radius;

    public Circle() {
        x = 5;
        y = 5;
        radius = 10;
    }
// providing definition of abstract method
    public void calculateArea() {
        double area = 3.14 * (radius * radius);
        System.out.println("Area: " + area);
    }
}//end of class