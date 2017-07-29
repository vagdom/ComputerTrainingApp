package testMVC;

import java.awt.event.*;

public class classController {
	
	//... The Controller needs to interact with both the Model and View.
    private classModel m_model;
    private classView  m_view;
    
    /** Constructor */
    classController(classModel model, classView view) {
        m_model = model;
        m_view  = view;
        
        //... Add listeners to the view.
        view.addOKListener(new OKListener());
        view.addClearListener(new ClearListener());
    }

////////////////////////////////////////////inner class ClearListener
/**  1. Reset model.
*   2. Reset View.
*/    
    class ClearListener implements ActionListener {
    	public void actionPerformed(ActionEvent e) {
    		m_model.reset();
    		m_view.reset();
    	}
    }// end inner class ClearListener
    
////////////////////////////////////////////inner class ClearListener
/**  1. Reset model.
*   2. Reset View.
*/    
    class OKListener implements ActionListener {
    	public void actionPerformed(ActionEvent e) {
    		m_model.OK();
    		m_view.OK();
    	}
    }// end inner class ClearListener
    
}
