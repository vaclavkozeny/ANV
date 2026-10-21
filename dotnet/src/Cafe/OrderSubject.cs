using System;
using System.Collections;
using System.Collections.Generic;
using Cafe.interfaces;

namespace Cafe;

public class OrderSubject
{
    private ArrayList observers;
    public OrderSubject()
    {
        observers = new ArrayList();
    }
    public void AddObserver(IObserver o)
    {
        observers.Add(o);
    }
    public List<string> NotifyAll(string msg)
    {
        List<string> notifications = new List<string>();
        foreach(IObserver o in observers)
        {
            notifications.Add(o.update(msg));
        }
        return notifications;
    }
}
