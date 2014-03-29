//File HelloWorldServlet.java
// importing required packages
import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;
// extending class from HttpServelt
public class HelloWorldServlet extends HttpServlet {
    /*
     * overriding doGet() method because writing a URL in the browser by default
     * generate request of GET type As you can see, HttpServletRequest and
     * HttpServletResponse are passed to this method. These objects will help in
     * processing of HTTP request and generating response for HTTP This method
     * can throw ServletException or IOException, so we mention these exception
     * types after method signature
     */

    public void doGet(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        /*
         * getting output stream i.e PrintWriter from response object by calling
         * getWriter method on it As mentioned, for generating response, we will
         * use HttpServletResponse object
         */
        PrintWriter out = response.getWriter();
        /*
         * printing Hello World in the browser using PrintWriter object. You can
         * also write HTML like out.println("<h1> Hello World </h1>")
         */
        out.println("Hello World! ");
    } // end doGet()
} // end HelloWorldServlet