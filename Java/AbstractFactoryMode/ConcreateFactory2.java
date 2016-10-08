
public class ConcreateFactory2 implements AbstractFactory {
	@Override 
	public ProductA FactoryA(){
		return new ConcreateProductA2();
	}
	@Override
	public ProductB FactoryB(){
		return new ConcreateProductB2();
	}
}
