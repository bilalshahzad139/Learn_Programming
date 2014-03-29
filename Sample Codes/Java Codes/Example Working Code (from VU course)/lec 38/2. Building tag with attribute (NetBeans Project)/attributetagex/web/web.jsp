<%-- using taglib directive, specifying the tld file and prefix --%>
<%@taglib uri="/WEB-INF/tlds/mytaglibrary.tld" prefix="mytag"%>
<html>
<body>
<center>
<h2> Welcome to Java Learning Center </h2>
<h3> Course Outline</h3>
<%--
calling coursetag and specifying java as attribute
value
--%>
<mytag:coursetag pageName="web" />
</center>
</body>
</html>