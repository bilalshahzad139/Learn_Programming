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
            //Step 5: creating PrepareStatement by passing sql and
            //ResultSet’s constants so that the ResultSet that will
            //produce as a result of executing query will be
            //scrollable & updatable
            String sql = "SELECT * FROM Person";
            PreparedStatement pStmt = con.prepareStatement(sql, ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_UPDATABLE);
            //Step 6: execute the query
            ResultSet rs = pStmt.executeQuery();
            // moving cursor forward i.e. first row
            rs.next();
            // printing column "name" value of current row (first)
            System.out.println("moving cursor forward");
            String name = rs.getString("Name");
            System.out.println(name);
            // moving cursor forward i.e. on to second row
            rs.next();
            // moving cursor backward i.e to first row
            rs.previous();

            // printing column "name" value of current row (first)
            System.out.println("moving cursor backward");
            name = rs.getString("Name");
            System.out.println(name);
            //Step 8: close the connection
            con.close();
        } catch (Exception sqlEx) {
            System.out.println(sqlEx);
        }
    } // end main
} // end class