
public class MainProgram {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ConcreateFactory1 factory1 = new ConcreateFactory1();
		ConcreateFactory2 factory2 = new ConcreateFactory2();
		
		ProductA myProductA1 = factory1.FactoryA();
		ProductB myProductB1 = factory1.FactoryB();
		
		ProductA myProductA2 = factory2.FactoryA();
		ProductB myProductB2 = factory2.FactoryB();
		
		myProductA1.method1();
		myProductA1.method2();
		
		myProductB1.method1();
		myProductB2.method2();
		
		myProductA2.method1();
		myProductA2.method2();
		
		myProductB2.method1();
		myProductB2.method2();

	}

}
