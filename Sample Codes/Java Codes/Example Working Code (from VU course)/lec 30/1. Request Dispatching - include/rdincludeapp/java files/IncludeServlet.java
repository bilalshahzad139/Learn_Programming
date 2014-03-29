import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class IncludeServlet extends HttpServlet {
// this method is being called by both doGet() and doPost()
    protected void processRequest(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
// Obtaining the object of PrintWriter, this will return the
// same PrintWriter object we have in MyServlet
        PrintWriter out = response.getWriter();
// Including a HTML tag using PrintWriter
        out.println("<h1> <marquee>I am included </marquee></h1>");
    }

    protected void doGet(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    protected void doPost(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
} // end IncludeServlet