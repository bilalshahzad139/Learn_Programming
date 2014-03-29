<html>
    <body>
        <%-- The code to sum two numbers if we used scriptlet
        < %
        String no1 = request .getParameter("num1");
        String no2 = request .getParameter("num2");
        int num1 = Integer.parseInt(no1);
        int num2 = Integer.parseInt(no2);
        %>
        Result is: <%= num1 + num2 %>
        --%>
        <%-- implicit Object param is used to access request parameters
        By Using EL summing two numbers
        --%>
        Result is: ${param.num1 + param.num2}
    </body>
</html>