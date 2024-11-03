using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerUnit : Unit
{
    [SerializeField] private List<EnemyUnit> enemyUnits;
    
    public List<EnemyUnit> EnemyUnits
    {
        get => enemyUnits;
    }

    [SerializeField] private UnitsOnScene unitsOnScene;

    public UnitsOnScene UnitsOnScene
    {
        set => unitsOnScene = value;
    }
}
