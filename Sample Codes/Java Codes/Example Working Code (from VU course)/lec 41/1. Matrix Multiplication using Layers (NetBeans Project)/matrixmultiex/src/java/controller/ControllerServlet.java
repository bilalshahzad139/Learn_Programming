package controller;
import bl.*;
import bo.* ;
import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class ControllerServlet extends HttpServlet {
// This method only calls processRequest()
protected void doGet(HttpServletRequest request,
HttpServletResponse response)
throws ServletException, IOException
{
processRequest(request, response);
}
// This method only calls processRequest()
protected void doPost(HttpServletRequest request,
HttpServletResponse response)
throws ServletException, IOException
{
processRequest(request, response);
}
protected void processRequest(HttpServletRequest request,
HttpServletResponse response)
throws ServletException, IOException
{
// retrieving values from input fields of matrixinput.jsp
String sMatrix1 = request.getParameter("firstMatrix");
String sMatrix2 = request.getParameter("secondMatrix");
// Creating MatrixMultipler object
MatrixMultiplier mm = new MatrixMultiplier();
// Passing Strings to convertToObject() method of MatrixMultiplier
// convertToObject() is used to convert strings into MatrixBean
MatrixBean fMatrix = mm.convertToObject(sMatrix1);
MatrixBean sMatrix = mm.convertToObject(sMatrix2);
// passing MatrixBean’s objects to multiply() method of
// MatrixMultiplier and receiving the product matrix in the form
// of MatrixBean
MatrixBean rMatrix = mm.multiply(fMatrix, sMatrix);
// saving results in database
mm.saveResult(rMatrix);
// storing the product of matrices into request, so that it can be
// retrieved on matrixresult.jsp
request.setAttribute("product", rMatrix);
// forwarding request to matrixresult.jsp
RequestDispatcher rd =
request.getRequestDispatcher("matrixresult.jsp");
rd.forward(request, response);
} // end processRequest()
} // end ControllerServlet