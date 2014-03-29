package bl;
import bo.*;
import dal.*;
import java.sql.SQLException;
public class MatrixMultiplier {
//constructor
public MatrixMultiplier( ) {
}
// used to convert a String (like 2,3,4,5) into a MatrixBean object
public MatrixBean convertToObject(String sMatrix){
//splitting received string into tokens by passing “,” as delimeter
String tokens[] = sMatrix.split(",");
//creating MatrixBean object
MatrixBean matrixBO = new MatrixBean();
// converting tokens into integers
int w = Integer.parseInt(tokens[0]);
int x = Integer.parseInt(tokens[1]);
int y = Integer.parseInt(tokens[2]);
int z = Integer.parseInt(tokens[3]);
// setting values into MatrixBean object by calling setter
matrixBO.setMatrix(w , x , y, z);
return matrixBO;
} // end convertToObject()
// used to multiply two matrices , receives two MatrixBean objects
// and returns the product in the form of MatrixBean as well
public MatrixBean multiply(MatrixBean fMatrix , MatrixBean sMatrix)
{
// creating MatrixBean object where product of the matrices will be
// stored
MatrixBean resultMatrix = new MatrixBean();
// retrieving two dimensional arrays from MatrixBeans object to
// perform multipication
int matrixA[ ][ ] = fMatrix.getMatrix();
int matrixB[ ][ ] = sMatrix.getMatrix();
int matrixC[ ][ ] = resultMatrix.getMatrix();

// code to multiply two matrices
for (int i=0; i<2; i++) {
for (int j=0; j<2; j++) {
for (int k=0; k<2; k++) {
matrixC[i][j] += (matrixA[i][k] * matrixB[k][j]);
}
}
}
// storing the product from 2d array to MatrixBean object by
// calling setter
resultMatrix.setMatrix( matrixC[0][0], matrixC[0][1],
matrixC[1][0], matrixC[1][1] );
return resultMatrix;
} // end multiply()
// save results (MatrixBean containg product of two matrices) into
// database using DAO
public void saveResult ( MatrixBean resultMatrix ) {
    MatrixDAO dao = null;
    try{
        dao = new MatrixDAO();
    }
    catch(ClassNotFoundException e){
        
    }
    catch(SQLException e){
        
    }

dao.saveMatrix(resultMatrix);
}
} // end MatrixMulitplier