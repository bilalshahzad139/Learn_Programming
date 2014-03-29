/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package vu;

import javax.servlet.jsp.JspWriter;
import javax.servlet.jsp.JspException;
import javax.servlet.jsp.tagext.JspFragment;
import javax.servlet.jsp.tagext.SimpleTagSupport;

/**
 *
 * @author Administrator
 */
public class WelcomeTagHandler extends SimpleTagSupport {

    /**
     * Called by the container to invoke this tag. The implementation of this
     * method is provided by the tag library developer, and handles all tag
     * processing, body iteration, etc.
     */
    @Override
    public void doTag() throws JspException {
        JspWriter out = getJspContext().getOut();

        try {
            out.println(" Hello World ");
        } catch (java.io.IOException ex) {
            throw new JspException(ex.getMessage());
        }
    }
}
