using UnityEngine;
using Zenject;

public class UnitsMonoInstaller : MonoInstaller

{
    [SerializeField] private PlayerUnit playerUnit;
    [SerializeField] private EnemyUnit enemyUnit;
    [SerializeField] private UnitsOnScene unitsOnScene;

    public override void InstallBindings()
    {
        BindPlayerUnit();
        SpawnEnemyUnit();
    }

    private void BindPlayerUnit()
    {
        var playerUnitOnScene = Container.InstantiatePrefabForComponent<PlayerUnit>(playerUnit);

        Container.Bind<PlayerUnit>().FromInstance(playerUnitOnScene).AsSingle();
    }

    private void SpawnEnemyUnit()
    {
        var enemyUnitOnScene = Container.InstantiatePrefabForComponent<EnemyUnit>(enemyUnit);
    }
}