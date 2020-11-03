using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCSharp
{
class Program
{
static void Main(string[] args)
{
  //Decorator Design Pattern  ==> In Decorator we can mixmatch the functionalities which are to be run on a particular Data
  IPizza pizza = new Pizza();
  IPizza CheeseDecorator = new ChesseDecorator(pizza);
  IPizza TomatoDecorator = new TomatoDecorator(CheeseDecorator);  
  IPizza OnionDecorator = new OnionDecorator(TomatoDecorator);
   Console.WriteLine(Cheesedecorator.GetPizzaType());
   Console.ReadLine();
}
}
  //base interface
	interface IPizza
	{
	   string GetPizzaType();//Method
	}


  //concrete implementation
	class Piza : IPizza
	{
	  public string GetPizzatype()
	{
	  return "This is a normal Pizza";
	}
	}

   //base decorator
	class PizzaDecorator : IPizza
	{
	 private IPizza _pizza;
	public PizzaDecorator(IPizza pizza)
	{
	  _pizza = pizza;
	}
	public virtual string GetPizzaType()
	{
	 return _pizza.GetPizzaType();
	}
	}

     //Concrete decorator
	
	class CheeseDecorator : PizzaDecorator
	{
	  public CheeseDecorator(IPizza pizza) : base(pizza) { }
	
	   public override string GetPizzaType()
	{
	  string type = base.GetPizzaType()
	  type += "\r\n with extra cheese";
	return type;

	}
	}
	class TomatoesDecorator : PizzaDecorator
	{
	  public TomatoesDecorator(IPizza pizza) : base(pizza) { }
	
	   public override string GetPizzaType()
	{
	  string type = base.GetPizzaType()
	  type += "\r\n with extra cheese";
	return type;

	}
	}
	class OnionDecorator : PizzaDecorator
	{
	  public OnionDecorator(IPizza pizza) : base(pizza) { }
	
	   public override string GetPizzaType()
	{
	  string type = base.GetPizzaType()
	  type += "\r\n with extra cheese";
	return type;

	}
	}















}