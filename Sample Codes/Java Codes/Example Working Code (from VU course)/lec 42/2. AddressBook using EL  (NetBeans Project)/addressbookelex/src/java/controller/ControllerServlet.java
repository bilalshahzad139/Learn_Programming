package controller;

import vu.*;
import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;
import java.util.*;

public class ControllerServlet extends HttpServlet {
// This method only calls processRequest()
    protected void doGet(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
// This method only calls processRequest()
    protected void doPost(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    protected void processRequest(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
// defined below

        searchPerson(request, response);
    } // end processRequest()

    protected void searchPerson(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        try {
// creating PersonDAO object
            PersonDAO pDAO = new PersonDAO();
// retrieving request parameter “name” entered on showperson.jsp
            String pName = request.getParameter("name");
// calling DAO method to retrieve personlist from database
// against the name entered by the user
            ArrayList personList = pDAO.retrievePersonList(pName);
// storing personlist in request scope, later it is retrieved
// back on showperson.jsp
            request.setAttribute("plist", personList);
// forwarding request to showperson, so it renders personlist
            RequestDispatcher rd =
                    request.getRequestDispatcher("showperson.jsp");
            rd.forward(request, response);
        } catch (Exception ex) {
            System.out.println("Exception is" + ex);
        }
    } // end searchPerson
} // end ControllerServlet