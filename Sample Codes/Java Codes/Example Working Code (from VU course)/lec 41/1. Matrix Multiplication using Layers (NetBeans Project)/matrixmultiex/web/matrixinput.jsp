<html>
<body>
<h2>
Enter Two Matrices of order 2 * 2 to compute Product
</h2>
<h3>
    <%--
"controller" is an alias/URL pattern of ControllerServlet
--%>
<form name="matrixInput" action="controller" >
First Matrix:
<input type="text" name = "firstMatrix" /> E.g. 2,3,4,1
<br/>
Second Matrix:
<input type="text" name = "secondMatrix" />
<br/>
<input type = "submit" value = "Calculate Product" />
</form>
</h3>
</body>
</html>