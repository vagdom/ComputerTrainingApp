package testMVC;

public class classModel {
	
	//... Constants
    private static final String INITIAL_VALUE = "0";
	
    private Integer m_salary;  // The total current value state.
    private String m_firstName;
    private String m_lastName;
    private String m_position;
    
	//============================================================== constructor
    /** Constructor */
    classModel() {
        reset();
    }
    
    //==================================================================== reset
    /** Reset to initial value. */
    public void reset() {
        m_salary = new Integer(INITIAL_VALUE);
        m_firstName = new String();
        m_lastName = new String();
        m_position = new String();
    }
    
    public void OK() {
    	
    	
    }
    
    //=============================================================== multiplyBy
    /** Multiply current total by a number.
    *@param operand Number (as string) to multiply total by.
    */
    /*
    public void multiplyBy(String operand) {
        m_total = m_total.multiply(new BigInteger(operand));
    }
    */
    //================================================================= setValue
    /** Set the total value. 
    *@param value New value that should be used for the calculator total. 
    */
    public void setFirstName(String value) {
        m_firstName = new String(value);
    }
    
    public void setLastName(String value) {
        m_lastName = new String(value);
    }
    
    public void setPosition(String value) {
        m_position = new String(value);
    }
    
    public void setSalary(String value) {
    	m_salary = new Integer(value);
    }
    
    //================================================================= getValue
    /** Return current calculator total. */
    public String getSalary() {
        return m_salary.toString();
    }
    
    public String getFirstName() {
        return m_firstName.toString();
    }

    public String getLastName() {
        return m_lastName.toString();
    }
 
    public String getPosition() {
        return m_position.toString();
    }
    
}
