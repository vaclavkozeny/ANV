using System;

namespace Cafe.interfaces;

public interface IObserver
{
    public string update(string msg);
}
