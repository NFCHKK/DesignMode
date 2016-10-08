/**
 * 
 */

/**
 * @author Danny
 * ��������ģʽ
 *
 */
/**
public class Adapter extends Adaptee implements TargetInterface {
	
	@Override
	public void Operation2(){
		System.out.println("Adapter Operation");
	}

}
*/
/**
 * @author Danny   
 * ����������ģʽ
 * 
 */

public class Adapter implements TargetInterface{
	private Adaptee adp;
	public Adapter(Adaptee adp){
		this.adp = adp;
	}
	
	public void Operation1(){
		adp.Operation1();
	}
	
	public void Operation2(){
		System.out.println("This is Adapter Operation2()");
	}
}
