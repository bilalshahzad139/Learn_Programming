<html>
<body>
<!-- scriptlet -->
<%
// reading parameter named page
String pageName = request.getParameter("page");
// redirecting user based on selection made
if (pageName.equals("web")) {
response.sendRedirect("web.jsp");
} else if (pageName.equals("java") ) {
response.sendRedirect("java.jsp");
}
%>
</body>
</html>