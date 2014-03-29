<%-- defining error page --%>
<%@page errorPage="addbookerror.jsp" %>
<%-- importing required packages. package vu contains JavaBeans --%>
<%@page import ="java.util.*" %>
<%@page import = "vu.*" %>
<html>
    <body>
        <%-- declaring PersonDAO object--%>
        <jsp:useBean id="pDAO" class="vu.PersonDAO" scope="page" />
        <%--
        scriptlet to identify JSP for redirection purpose if
        request comes from hyperlinks
        --%>
        <%
        // retrieving action parameter value
        // Remember that ?action? is the name of buttons as well
        // it is used in hyperlinks in making of query string
            String action = request.getParameter("action");
        // if "Add Person" hyperlink is clicked
            if (action.equals("addperson")) {
                response.sendRedirect("addperson.jsp");
        // if "Search Person" hyperlink is clicked
            } else if (action.equals("searchperson")) {
                response.sendRedirect("searchperson.jsp");
        // if "save" button is clicked of addperson.jsp
            } else if (action.equals("save")) {
        %>
        // declaring PersonInfo obeject
        <jsp:useBean id="personBean" class="vu.PersonInfo" scope="page"/>
        <%--
        setting all properties of personBean object with input
        parameters using *
        --%>
        <jsp:setProperty name="personBean" property="*" />

        <%-- to insert record into database--%>
        <%
            pDAO.addPerson(personBean);
        // redirecting user to saveperson.jsp
            response.sendRedirect("saveperson.jsp");
        %>
        <%-- if "search" button is clicked on searchperson.jsp --%>
        <%
        } else if (action.equals("search")) {
            String pName = request.getParameter("name");
            ArrayList personList = pDAO.retrievePersonList(pName);
        // storing personList(contains PersonInfo objects) into
        // request hashmap
            request.setAttribute("list", personList);
        %>
        <%--
        forwarding request to showperson.jsp to retrieve
        stored arraylist (?list?)
        --%>
        <jsp:forward page="showperson.jsp" />
        <%
            } // end if page == search
        %>
    </body>
</html>