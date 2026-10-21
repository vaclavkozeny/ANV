using System;
using Cafe.interfaces;

namespace Cafe;

public class EmployeeObserver : IObserver
{
    private string _name;
    private string _position;
    public string GetName()
    {
        return _name;
    }
    public string GetPosition()
    {
        return _position;
    }
    public EmployeeObserver(string n, string p)
    {
        _name = n;
        _position = p;
    }
    public string update(string msg) => $"{_name} notified: {msg}";
}
