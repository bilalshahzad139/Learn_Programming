package dal;

import java.util.*;
import java.sql.*;
import bo.*;

public class MatrixDAO {

    private Connection con;
// constructor
    public MatrixDAO() throws ClassNotFoundException, SQLException {
        establishConnection();
    }

// method used to establish connection with db
    private void establishConnection() throws ClassNotFoundException,
            SQLException {
// establishing conection
        Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
        String conUrl = "jdbc:odbc:MatrixDSN";
        con = DriverManager.getConnection(conUrl);
    }
// used to store MatrixBean into database after converting it to
// a String
    public void saveMatrix(MatrixBean matrix) {
        try {
            String sql = "INSERT INTO Matrix(mOrder, mValues) VALUES (?,?)";
            PreparedStatement pStmt = con.prepareStatement(sql);
// converting MatrixBean into String by calling toString()
            String sMatrix = matrix.toString();
// setting order of matrix
            pStmt.setString(1, "2*2");
// setting matrix values in the form of string
            pStmt.setString(2, sMatrix);
            pStmt.executeUpdate();
        } catch (SQLException sqlex) {
            System.out.println(sqlex);
        }
    } // end saveMatrix
// overriding finalize method to release acquired resources
    public void finalize() {
        try {
            if (con != null) {
                con.close();
            }
        } catch (SQLException sex) {
            System.out.println(sex);
        }
    } // end finalize
} // end MatrixDAO class