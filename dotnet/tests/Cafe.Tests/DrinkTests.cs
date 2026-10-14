using Cafe.drinks;
using Xunit;

namespace Cafe.Tests;

public class DrinkTests
{
    [Fact]
    public void Tea_Serve_ReturnsServingTea()
    {
        Assert.Equal("Serving tea", new Tea().Serve());
    }

    [Fact]
    public void Coffe_Serve_ReturnsServingCoffe()
    {
        Assert.Equal("Serving coffe", new Coffe().Serve());
    }

    [Fact]
    public void Drinks_ImplementIDrink()
    {
        Assert.IsAssignableFrom<IDrink>(new Tea());
        Assert.IsAssignableFrom<IDrink>(new Coffe());
    }
}
