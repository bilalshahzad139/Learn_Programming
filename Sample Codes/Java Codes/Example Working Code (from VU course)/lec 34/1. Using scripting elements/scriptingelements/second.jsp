<html>
<body>
<!-- JSP to sum two numbers -->
<%-- Declaration--%>
<%!
// declaring a variable to store sum
int res;
// method helps in calculating the sum
public int sum(int op1, int op2) {
return op1 + op2;
}
%>
<%-- Scripltet--%>
<%
String op1 = request.getParameter("num1");
String op2 = request.getParameter("num2");
int firstNum = Integer.parseInt(op1);
int secondNum = Integer.parseInt(op2);
// calling method sum(), declared above in declartion tag
res = sum(firstNum, secondNum);
%>
<%-- expression used to display sum --%>
<h3>Sum is: <%=res%> </h3>
</body>
</html>