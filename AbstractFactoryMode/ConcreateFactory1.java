
public class ConcreateFactory1 implements AbstractFactory {
	@Override
	public ProductA FactoryA(){
		return new ConcreateProductA1();
	}
	
	@Override
	public ProductB FactoryB(){
		return new ConcreateProductB1();
	}
}
