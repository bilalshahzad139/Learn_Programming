// File ResultSetEx.java
import java.sql.*;

public class ResultSetEx {

    public static void main(String args[]) {
        try {
//Step 2: load driver
            Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
//Step 3: define the connection URL
            String url = "jdbc:odbc:personDSN";
            //Step 4: establish the connection
            Connection con = DriverManager.getConnection(url);
            //Step 5: create PrepareStatement by passing sql and
            // ResultSet appropriate fields
            String sql = "SELECT * FROM Person";
            PreparedStatement pStmt = con.prepareStatement(sql,
                    ResultSet.TYPE_SCROLL_INSENSITIVE,
                    ResultSet.CONCUR_UPDATABLE);
            //Step 6: execute the query
            ResultSet rs = pStmt.executeQuery();
            // moving cursor to insert row
            rs.moveToInsertRow();
            // updating values in insert row
            rs.updateString("Name", "imitiaz");
            rs.updateString("Address", "cantt");
            rs.updateString("phoneNum", "9201211");
            // inserting row in resultset & into database
            rs.insertRow();
            //Step 8: close the connection
            con.close();
        } catch (Exception sqlEx) {
            System.out.println(sqlEx);
        }
    } // end main
} // end class