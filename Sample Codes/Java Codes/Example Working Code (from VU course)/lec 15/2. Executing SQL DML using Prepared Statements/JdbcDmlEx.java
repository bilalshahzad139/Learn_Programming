// File JdbcDmlEx.java
//step 1: import package
import java.sql.*;

public class JdbcDmlEx {

    public static void main(String args[]) {
        try {
//Step 2: load driver
            Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
//Step 3: define the connection URL
            String url = "jdbc:odbc:personDSN";
//Step 4: establish the connection
            Connection con = DriverManager.getConnection(url, "", "");
// make query and place ? where values are to
//be inserted later
            String sql = "UPDATE Person SET address = ? "
                    + " WHERE name = ? ";
// creating statement using Connection object and passing
// sql statement as parameter
            PreparedStatement pStmt = con.prepareStatement(sql);
// assigning first command line argument value
            String addVar = args[0];
// assigning second command line argument value
            String nameVar = args[1];
// setting first marked parameter (?) by using setString()
// method to address.
            pStmt.setString(1, addVar);
// setting second marked parameter(?) by using setString()
// method to name
            pStmt.setString(2, nameVar);
// suppose address is "defence" & name is "ali"
// by setting both marked parameters, the query will look
// like:
// sql = "UPDATE Person SET address = "defence"
// WHERE name = "ali" "
// executing update statemnt
            int num = pStmt.executeUpdate();
// Step 7: process the results of the query
// printing number of records affected
            System.out.println(num + " records updated");
//Step 8: close the connection
            con.close();
        } catch (Exception sqlEx) {
            System.out.println(sqlEx);
        }
    } // end main
} // end class