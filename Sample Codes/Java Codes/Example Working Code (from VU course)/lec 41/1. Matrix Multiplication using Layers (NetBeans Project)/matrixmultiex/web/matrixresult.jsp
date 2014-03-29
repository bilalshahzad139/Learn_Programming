<%-- importing ?bo? package that contains MatrixBean --%>
<%@ page import="bo.*"%>
<html>
<body>
<h1>The resultant Matrix is </h1>
<%--
retrieving MatrixBean object from request, that was set on
ControllerServlet
--%>
<%
MatrixBean productMatrix =
(MatrixBean)request.getAttribute("product");
// retrieving values in 2d array so that it can be displayed
int matrix[][] = productMatrix.getMatrix() ;
%>
<%-- displaying MatrixBean?s object values --%>
<TABLE>
<TR>
<TD> <%= matrix[0][0] %> </TD>
<TD> <%= matrix[0][1] %> </TD>
</TR>
<TR>
<TD> <%= matrix[1][0] %> </TD>
<TD> <%= matrix[1][1] %> </TD>
</TR>
</TABLE>
</body>
</html>