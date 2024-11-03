using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class EnemyUnit : Unit
{
    [SerializeField] private PlayerUnit playerUnit;

    public PlayerUnit PlayerUnit
    {
        set => playerUnit = value;
    }
    [SerializeField] private UnitsOnScene unitsOnScene;

        public UnitsOnScene UnitsOnScene
    {
        set => unitsOnScene = value;
    }
}
