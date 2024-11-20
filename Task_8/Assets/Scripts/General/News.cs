using UnityEngine;

public interface IObserver
{
    void Update(News news);
}

public interface IObservable
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

public class News : MonoBehaviour
{
    public News(string title, string overview)
    {
        Title = title;
        Overview = overview;
    }
    public string Title;
    public string Overview;
}
