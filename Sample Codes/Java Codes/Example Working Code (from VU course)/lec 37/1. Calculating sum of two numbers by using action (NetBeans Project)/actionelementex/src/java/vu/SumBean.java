package vu;

import java.io.*;

public class SumBean implements Serializable {

    private int firstNumber;
    private int secondNumber;
    private int sum;
// no argument constructor
    public SumBean() {
        firstNumber = 0;
        secondNumber = 0;
        sum = 0;
    }
// firstNumber & secondNumber are writeonly properties
// setters
    public void setFirstNumber(int n) {
        firstNumber = n;
    }

    public void setSecondNumber(int n) {
        secondNumber = n;
    }
// no setter for sum
// sum is a read only property
    public int getSum() {
        return sum;
    }
// method to calculate sum
    public void calculateSum() {
        sum = firstNumber + secondNumber;
    }
}