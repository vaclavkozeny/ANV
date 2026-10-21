using Xunit;

namespace Cafe.Tests;

public class EmployeeObserverTests
{
    [Fact]
    public void Constructor_StoresNameAndPosition()
    {
        var observer = new EmployeeObserver("pepa", "barista");

        Assert.Equal("pepa", observer.GetName());
        Assert.Equal("barista", observer.GetPosition());
    }

    [Fact]
    public void Update_ReturnsNameAndMessage()
    {
        var observer = new EmployeeObserver("pepa", "barista");

        Assert.Equal("pepa notified: Ordered Coffee", observer.update("Ordered Coffee"));
    }

    [Fact]
    public void Update_DoesNotWriteToConsole()
    {
        var observer = new EmployeeObserver("pepa", "barista");
        var original = Console.Out;
        var writer = new StringWriter();
        Console.SetOut(writer);
        try
        {
            observer.update("msg");
        }
        finally
        {
            Console.SetOut(original);
        }

        Assert.Equal(string.Empty, writer.ToString());
    }
}
