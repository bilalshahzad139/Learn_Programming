import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class MyServlet extends HttpServlet {
// Handles the HTTP GET request type
    protected void doGet(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
// Handles the HTTP POST request type
    protected void doPost(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    protected void processRequest(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        String id = request.getParameter("userid");
        String pwd = request.getParameter("pwd");
// comparing id & password with fix values
        if (id.equals("ali") && pwd.equals("vu")) {
// redirectign user to welcome.html
            response.sendRedirect("welcome.html");
        } else {
// redirecting user to register.html
            response.sendRedirect("register.html");
            /*
             * if you want to display an error message to the user, you can use
             * the following method response.sendError(
             * response.SC_PROXY_AUTHENTICATION_REQUIRED, "Send Error Demo" );
             */
        } // end else
    }
}