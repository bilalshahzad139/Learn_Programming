<html>
<body>
<!-- scriptlet -->
<%
// reading parameter “page”, name of radio button using
// implicit object request
String pageName = request.getParameter("page");
// deciding which page to move on based on “page” value
// redirecting user by using response implicit object
if (pageName.equals("web")) {
response.sendRedirect("web.jsp");
} else if (pageName.equals("java") ) {
response.sendRedirect("java.jsp");
}
%>
</body>
</html>