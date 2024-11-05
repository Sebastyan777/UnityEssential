using UnityEngine;
using Zenject;

public class DiInstaller : MonoInstaller
{
    [SerializeField] private Bullet bullet;
    [SerializeField] private Artillery artillery;

    public override void InstallBindings()
    {
        BindBulletFactory();
        BindArtillery();
    }

    private void BindBulletFactory()
    {
        Container
                .BindFactory<Vector3, Vector3, float, Bullet, Bullet.Factory>()
                .FromComponentInNewPrefab(bullet)
                .AsSingle();
    }

    private void BindArtillery()
    {
        var ArtilleryOnScene = Container.InstantiatePrefabForComponent<Artillery>(artillery);

        Container.Bind<Artillery>().FromInstance(ArtilleryOnScene).AsSingle();
    }
}