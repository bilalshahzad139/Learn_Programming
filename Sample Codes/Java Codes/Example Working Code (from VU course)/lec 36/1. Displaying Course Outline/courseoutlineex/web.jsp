// importing java.sql package using page directive, to work with
// database
<%@page import="java.sql.*"%>
<html>
<body>
<center>
<h2> Welcome to Web Design & Development Page </h2>
<h3> Course Outline</h3>
<TABLE BORDER="1" >
<TR>
<TH>Session No.</TH>
<TH>Topics</TH>
<TH>Assignments</TH>
</TR>
<%-- start of scriptlet --%>
<%
// establishing conection
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String conUrl = "jdbc:odbc:CourseDSN";
Connection con = DriverManager.getConnection(conUrl);
// preparing query using join statements
String sql = " SELECT sessionNo, topic, assignment " +
" FROM Course, SessionDetail" +
" WHERE courseName = ? " +
" AND Course.courseId = SessionDetail.courseID";
PreparedStatement pStmt = con.prepareStatement(sql);
// setting parameter value ”web”.
pStmt.setString( 1 , "web");
ResultSet rs = pStmt.executeQuery();
String sessionNo;
String topic;
String assignment;
// iterating over resultset
while (rs.next()) {
sessionNo = rs.getString("sessionNo");
topic = rs.getString("topic");
assignment = rs.getString("assignment");
if (assignment == null){
assignment = "";
}
%>
<%-- end of scriptlet --%>
<%-- The values are displayed in tabular format using
expressions, however it can also be done using
out.println(sessionNo) like statements
--%>
<TR>
<TD> <%=sessionNo%> </TD>
<TD> <%=topic%> </TD>
<TD> <%=assignment%> </TD>
</TR>
<%
} // end while
%>
</TABLE >
</center>
</body>
</html>