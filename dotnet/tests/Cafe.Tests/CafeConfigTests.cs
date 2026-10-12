using System.Reflection;
using Xunit;

namespace Cafe.Tests;

public class CafeConfigTests
{
    [Fact]
    public void GetInstance_ReturnsNotNull()
    {
        Assert.NotNull(CafeConfig.getInstance());
    }

    [Fact]
    public void GetInstance_ReturnsSameInstanceOnRepeatedCalls()
    {
        var first = CafeConfig.getInstance();
        var second = CafeConfig.getInstance();

        Assert.Same(first, second);
    }

    [Fact]
    public void GetCafeName_ReturnsCafe()
    {
        Assert.Equal("cafe", CafeConfig.getInstance().getCafeName());
    }

    [Fact]
    public void GetCafeName_IsSameThroughDifferentReferences()
    {
        var first = CafeConfig.getInstance();
        var second = CafeConfig.getInstance();

        Assert.Equal(first.getCafeName(), second.getCafeName());
    }

    [Fact]
    public void Constructor_IsPrivate()
    {
        var publicCtors = typeof(CafeConfig).GetConstructors(BindingFlags.Public | BindingFlags.Instance);
        var nonPublicCtors = typeof(CafeConfig).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);

        Assert.Empty(publicCtors);
        Assert.Single(nonPublicCtors);
        Assert.True(nonPublicCtors[0].IsPrivate);
    }
}
