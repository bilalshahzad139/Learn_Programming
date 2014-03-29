<html>
    <body>
        <!-- scriptlet -->
        <%
            String pageName = request.getParameter("page");
            if (pageName.equals("web")) {
                response.sendRedirect("web.jsp");
            } else if (pageName.equals("java")) {
                response.sendRedirect("java.jsp");
            }
        %>
    </body>
</html>