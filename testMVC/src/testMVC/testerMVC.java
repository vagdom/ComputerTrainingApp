package testMVC;

public class testerMVC {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		classModel      model      = new classModel();
        classView       view       = new classView(model);
        classController controller = new classController(model, view);
        
        view.setVisible(true);

	}

}
