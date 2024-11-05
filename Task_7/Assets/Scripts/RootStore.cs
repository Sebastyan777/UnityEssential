using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class RootStore : MonoBehaviour
{
    [Inject] private LootBox.Factory _lootBoxFactory;
    [Inject] private UICanvas _uicanvas;

    private void Awake()
    {
        transform.SetParent(_uicanvas.transform, false);
    }

    [ContextMenu("Create LootBox")]

    public void CreateLootBox()
    {
        var box = _lootBoxFactory.Create();
        box.transform.SetParent(transform);
    }
}
