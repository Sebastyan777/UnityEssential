using UnityEngine;

public class NewsAgent : MonoBehaviour
{
    [SerializeField] private NewsAgregator newsAgregator;
    [ContextMenu("Test")]
    public void CreateNews()
    {
        var news = new News("Заголовок 1", "Тело 1");
        newsAgregator.LastNews = news;
    }
}
