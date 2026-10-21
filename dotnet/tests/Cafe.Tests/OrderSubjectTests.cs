using Cafe.interfaces;
using Xunit;

namespace Cafe.Tests;

public class OrderSubjectTests
{
    private sealed class SpyObserver : IObserver
    {
        public List<string> Received { get; } = new();

        public string update(string msg)
        {
            Received.Add(msg);
            return $"spy:{msg}";
        }
    }

    [Fact]
    public void NotifyAll_NoObservers_ReturnsEmpty()
    {
        Assert.Empty(new OrderSubject().NotifyAll("msg"));
    }

    [Fact]
    public void NotifyAll_CallsUpdateOnEveryObserver()
    {
        var order = new OrderSubject();
        var a = new SpyObserver();
        var b = new SpyObserver();
        order.AddObserver(a);
        order.AddObserver(b);

        order.NotifyAll("Ordered Tea");

        Assert.Equal(new[] { "Ordered Tea" }, a.Received);
        Assert.Equal(new[] { "Ordered Tea" }, b.Received);
    }

    [Fact]
    public void NotifyAll_ReturnsResultsInRegistrationOrder()
    {
        var order = new OrderSubject();
        order.AddObserver(new EmployeeObserver("pepa", "barista"));
        order.AddObserver(new EmployeeObserver("marie", "pokladní"));

        var result = order.NotifyAll("Ordered Coffee");

        Assert.Equal(
            new[] { "pepa notified: Ordered Coffee", "marie notified: Ordered Coffee" },
            result);
    }

    [Fact]
    public void NotifyAll_CalledTwice_NotifiesTwice()
    {
        var order = new OrderSubject();
        var spy = new SpyObserver();
        order.AddObserver(spy);

        order.NotifyAll("one");
        order.NotifyAll("two");

        Assert.Equal(new[] { "one", "two" }, spy.Received);
    }
}
