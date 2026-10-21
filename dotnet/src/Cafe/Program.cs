using Cafe.drinks;
using Cafe.enums;

namespace Cafe;

public static class Program
{
    public static void Main(string[] args)
    {
        CafeConfig c = CafeConfig.GetInstance();
        DrinkFactory f = new DrinkFactory();
        CustomDrink drink = new CustomDrink.Builder(DrinkType.Tea)
            .Milk()
            .Sugar()
            .Caramel()
            .Build();

        OrderSubject o = new OrderSubject();
        o.AddObserver(new EmployeeObserver("pepa","barista"));
        o.AddObserver(new EmployeeObserver("marie","pokladní"));
        string msg = $"{drink} in {c.getCafeName()}";
        foreach (string notification in o.NotifyAll(msg))
        {
            Console.WriteLine(notification);
        }
    }
}
