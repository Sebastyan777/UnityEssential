using UnityEngine;
using Zenject;

public class DiInstaller : MonoInstaller
{
    [SerializeField] private UICanvas uICanvas;
    [SerializeField] private LootBox lootBox;
    [SerializeField] private RootStore rootStore;

    public override void InstallBindings()
    {
        BindUICanvas();
        BindLootBoxFactory();
        BindRootStore();
    }

    private void BindUICanvas()
    {
        var canvas = Container.InstantiatePrefabForComponent<UICanvas>(uICanvas);

        Container.Bind<UICanvas>().FromInstance(canvas).AsSingle();
    }

    private void BindLootBoxFactory()
    {
        Container.BindFactory<LootBox, LootBox.Factory>().FromComponentInNewPrefab(lootBox).AsSingle();
    }

    private void BindRootStore()
    {
        var rootStoreOnScene = Container.InstantiatePrefabForComponent<RootStore>(rootStore);

        Container.Bind<RootStore>().FromInstance(rootStoreOnScene).AsSingle();
    }
}