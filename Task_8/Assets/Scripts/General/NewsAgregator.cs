using System.Collections.Generic;
using UnityEngine;

public class NewsAgregator : MonoBehaviour, IObservable
{
    private List<IObserver> _observers;
    private News _lastNews;
    public News LastNews
    {
        set => _lastNews = value;
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    [ContextMenu("Test")]
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_lastNews);
        }
    }
}
