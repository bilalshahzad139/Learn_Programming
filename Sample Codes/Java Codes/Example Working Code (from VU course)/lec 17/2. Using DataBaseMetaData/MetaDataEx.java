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
            // getting DataBaseMetaDat object
            DatabaseMetaData dbMetaData = con.getMetaData();
            // printing database product name
            String pName = dbMetaData.getDatabaseProductName();
            System.out.println("DataBase: " + pName);
            // printing database product version
            String pVer = dbMetaData.getDatabaseProductVersion();
            System.out.println("Version: " + pVer);
            // printing driver name used to establish connection &
            // to retrieve data
            String dName = dbMetaData.getDriverName();
            System.out.println("Driver: " + dName);
            // printing whether database is read-only or not
            boolean rOnly = dbMetaData.isReadOnly();
            System.out.println("Read-Only: " + rOnly);
            // you can create & execute statements and can
            // process results over here if needed
            //Step 8: close the connection
            con.close();
        } catch (Exception sqlEx) {
            System.out.println(sqlEx);
        }
    } // end main
} // end class