package testMVC;

import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
import javax.swing.border.EmptyBorder;

public class classView extends JFrame{
	
	 private static final String INITIAL_VALUE = "0";
	
	//... Components
    private JTextField m_firstName = new JTextField(5);
    private JTextField m_lastName = new JTextField(5);
    private JTextField m_position = new JTextField(5);
    private JTextField m_salary = new JTextField(5);
    
    private JButton    m_okBtn = new JButton("OK");
    
    
    private JButton    m_clearBtn    = new JButton("Clear");
    
    private classModel m_model;
    
    //...Constructor
    classView(classModel model) {
        
    	//... Set up the logic
        m_model = model;
       
        //... Layout the components. 
        
        JPanel content = new JPanel(new BorderLayout(3,3));
        content.setBorder(new EmptyBorder(5,5,5,5));
        
        JPanel labels = new JPanel(new GridLayout(0,1));
        JPanel controls = new JPanel(new GridLayout(0,1));
        JPanel buttons = new JPanel(new FlowLayout());
        
        content.add(labels, BorderLayout.WEST);
        content.add(controls, BorderLayout.CENTER);
        content.add(buttons, BorderLayout.SOUTH);
        
        
        labels.add(new JLabel("First Name: "));
        controls.add(m_firstName);
        labels.add(new JLabel("Last Name: "));
        controls.add(m_lastName);
        labels.add(new JLabel("Position: "));
        controls.add(m_position);
        labels.add(new JLabel("Salary: "));
        controls.add(m_salary);
              
        
        buttons.add(m_okBtn, BorderLayout.WEST);
        buttons.add(m_clearBtn, BorderLayout.EAST);
        
        //... finalize layout
        this.setContentPane(content);
        this.pack();
        
        this.setLocationRelativeTo(null);
        this.setSize(500,200);
        this.setResizable(false); 
        
        this.setTitle("Simple Calc - MVC");
        // The window closing event should probably be passed to the 
        // Controller in a real program, but this is a short example.
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    
    void reset() {
    	
    	m_firstName.setText("");
    	m_lastName.setText("");
    	m_position.setText("");
        m_salary.setText(INITIAL_VALUE);
        
    }
    
    void OK() {
    	
    	String message = m_firstName.getText();
    	message += " , ";
    	message += m_lastName.getText(); 
    	
    	JOptionPane.showMessageDialog(null, message, "InfoBox: " + "Test 2", JOptionPane.INFORMATION_MESSAGE);
    }
    
    String getFirstName() {
        return m_firstName.getText();
    }
    
    String getLastName() {
        return m_lastName.getText();
    }
    
    String getPosition() {
        return m_position.getText();
    }
    
    String getSalary() {
        return m_salary.getText();
    }
            
    void showError(String errMessage) {
        JOptionPane.showMessageDialog(this, errMessage);
    }
    /*
    void setTotal(String newTotal) {
        m_totalTf.setText(newTotal);
    }
    
    void addMultiplyListener(ActionListener mal) {
        m_multiplyBtn.addActionListener(mal);
    }
    */
    void addClearListener(ActionListener cal) {
        m_clearBtn.addActionListener(cal);
    }
    
    void addOKListener(ActionListener OK) {
        m_okBtn.addActionListener(OK);
    }

}
