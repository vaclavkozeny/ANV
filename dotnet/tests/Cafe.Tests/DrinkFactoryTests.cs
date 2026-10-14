using Cafe.drinks;
using Cafe.enums;
using Xunit;

namespace Cafe.Tests;

public class DrinkFactoryTests
{
    private readonly DrinkFactory _factory = new();

    [Fact]
    public void CreateDrink_Tea_ReturnsTea()
    {
        Assert.IsType<Tea>(_factory.CreateDrink(DrinkType.Tea));
    }

    [Fact]
    public void CreateDrink_Coffe_ReturnsCoffe()
    {
        Assert.IsType<Coffe>(_factory.CreateDrink(DrinkType.Coffe));
    }

    [Fact]
    public void CreateDrink_UnknownType_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _factory.CreateDrink((DrinkType)999));
    }

    [Fact]
    public void CreateDrink_ReturnsNewInstanceEachTime()
    {
        Assert.NotSame(_factory.CreateDrink(DrinkType.Tea), _factory.CreateDrink(DrinkType.Tea));
    }
}
