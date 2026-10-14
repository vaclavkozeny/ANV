using Cafe.drinks;
using Cafe.enums;
using Xunit;

namespace Cafe.Tests;

public class CustomDrinkTests
{
    [Fact]
    public void ToString_BaseOnly_ReturnsBaseServe()
    {
        var drink = new CustomDrink.Builder(DrinkType.Tea).Build();

        Assert.Equal("Serving tea", drink.ToString());
    }

    [Fact]
    public void ToString_CoffeBase_UsesCoffe()
    {
        var drink = new CustomDrink.Builder(DrinkType.Coffe).Build();

        Assert.Equal("Serving coffe", drink.ToString());
    }

    [Fact]
    public void ToString_Milk_AddsMilk()
    {
        var drink = new CustomDrink.Builder(DrinkType.Coffe).Milk().Build();

        Assert.Equal("Serving coffe, milk", drink.ToString());
    }

    [Fact]
    public void ToString_Sugar_AddsSugar()
    {
        var drink = new CustomDrink.Builder(DrinkType.Tea).Sugar().Build();

        Assert.Equal("Serving tea, sugar", drink.ToString());
    }

    [Fact]
    public void ToString_Caramel_AddsCaramel()
    {
        var drink = new CustomDrink.Builder(DrinkType.Tea).Caramel().Build();

        Assert.Equal("Serving tea, caramel", drink.ToString());
    }

    [Fact]
    public void ToString_AllExtras_AreInFixedOrder()
    {
        var drink = new CustomDrink.Builder(DrinkType.Coffe)
            .Caramel().Sugar().Milk().Build();

        Assert.Equal("Serving coffe, milk, sugar, caramel", drink.ToString());
    }

    [Fact]
    public void Builder_MethodsReturnSameBuilder()
    {
        var builder = new CustomDrink.Builder(DrinkType.Tea);

        Assert.Same(builder, builder.Milk());
        Assert.Same(builder, builder.Sugar());
        Assert.Same(builder, builder.Caramel());
    }

    [Fact]
    public void Build_SnapshotsState_LaterChangesDoNotAffectBuiltDrink()
    {
        var builder = new CustomDrink.Builder(DrinkType.Tea);
        var drink = builder.Build();
        builder.Milk();

        Assert.Equal("Serving tea", drink.ToString());
    }
}
