import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class MyServlet extends HttpServlet {
// attribute used to store init-parameter value
    String fileName;
// overriding init() method
    public void init(ServletConfig config) throws ServletException {
        super.init(config);
// reading init-parameter "logfilename" stored in web.xml
        fileName = config.getInitParameter("logfilename");
    }
    /*
     * Both doGet() & doPost() methods are override over here. processRequest()
     * is called from both these methods. This makes possible for a servlet to
     * handle both POST and GET requests identically.
     */
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
// called from doGet() & doPost()
    protected void processRequest(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        PrintWriter out = response.getWriter();
// writing init-parameter value that is store in fileName
        out.println(fileName);
        out.close();
    }
} // end MyServlet