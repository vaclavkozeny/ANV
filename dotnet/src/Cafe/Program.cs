using Cafe.drinks;
using Cafe.enums;

namespace Cafe;

public static class Program
{
    public static void Main(string[] args)
    {
        CafeConfig c = CafeConfig.GetInstance();
        Console.WriteLine(c.getCafeName());
        DrinkFactory f = new DrinkFactory();
        Console.WriteLine(f.CreateDrink(DrinkType.Tea).Serve() + " in " + c.getCafeName());
        CustomDrink drink = new CustomDrink.Builder(DrinkType.Tea)
            .Milk()
            .Sugar()
            .Caramel()
            .Build();
        Console.WriteLine(drink);

        CustomDrink simple = new CustomDrink.Builder(DrinkType.Coffe)
            .Sugar()
            .Build();
        Console.WriteLine(simple);
    }
}
