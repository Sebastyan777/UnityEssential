using UnityEngine;

public class NewsReader : MonoBehaviour, IObserver
{
    void Start()
    {
        var agregator = FindObjectOfType<NewsAgregator>();
        agregator.AddObserver(this);
    }

    public void Update(News news)
    {
        Debug.Log($"{GetHashCode()}: {news.Title}, {news.Overview}");
    }
}
