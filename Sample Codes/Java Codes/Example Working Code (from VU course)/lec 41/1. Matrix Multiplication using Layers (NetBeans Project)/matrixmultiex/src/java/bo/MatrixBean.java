package bo;
import java.io.*;
public class MatrixBean implements Serializable{
// a 2D array representing matrix
public int matrix[ ][ ] ;
// constructor
public MatrixBean()
{
matrix = new int[2][2];
matrix[0][0] = 0;
matrix[0][1] = 0;
matrix[1][0] = 0;
matrix[1][1] = 0;
}
// setter that takes 4 int values and assigns these to array
public void setMatrix(int w, int x, int y, int z)
{
matrix[0][0] = w;
matrix[0][1] = x;
matrix[1][0] = y;
matrix[1][1] = z;
}
// getter returning a 2D array
public int[ ][ ] getMatrix()
{
return matrix;
}
// used to convert 2D array into string
public String toString()
{
return matrix[0][0] + "," + matrix[0][1] + "," +
matrix[1][0] + "," +matrix[1][1] ;
}
} // end MatrixBean