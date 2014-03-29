// File MetaDataEx.java
import java.sql.*;

public class MetaDataEx {

    public static void main(String args[]) {
        try {
//Step 2: load driver
            Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
//Step 3: define the connection URL
            String url = "jdbc:odbc:personDSN";
//Step 4: establish the connection
            Connection con = null;
            con = DriverManager.getConnection(url, "", "");
//Step 5: create PrepareStatement by passing sql and
// ResultSet appropriate fields
            String sql = "SELECT * FROM Person";
            PreparedStatement pStmt = con.prepareStatement(sql,
                    ResultSet.TYPE_SCROLL_INSENSITIVE,
                    ResultSet.CONCUR_UPDATABLE);
//Step 6: execute the query
            ResultSet rs = pStmt.executeQuery();
// get ResultSetMetaData object from rs
            ResultSetMetaData rsmd = rs.getMetaData();
// printing no. of column contained by rs
            int numColumns = rsmd.getColumnCount();
            System.out.println("Number of Columns:" + numColumns);
// printing all column names by using for loop
            String cName;
            for (int i = 1; i <= numColumns; i++) {
                cName = rsmd.getColumnName(i);
                System.out.print(cName);
                System.out.print("\t");
            }

// changing line or printing an empty string
            System.out.println(" ");
// printing all values of ResultSet by iterating over it
            String id, name, add, ph;
            while (rs.next()) {
                id = rs.getString(1);
                name = rs.getString(2);
                add = rs.getString(3);
                ph = rs.getString(4);
                System.out.print(id);
                System.out.print("\t");
                System.out.print(name);
                System.out.print("\t");
                System.out.print(add);
                System.out.print("\t");
                System.out.print(ph);
                System.out.println(" ");
            }
//Step 8: close the connection
            con.close();
        } catch (Exception sqlEx) {
            System.out.println(sqlEx);
        }
    } // end main
} // end class