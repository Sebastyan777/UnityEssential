using UnityEngine;
using UnityEngine.UIElements.Experimental;
using Zenject;

public class EnemyUnit : Unit
{
    private PlayerUnit _playerUnit;

    [Inject]
    private void Construct(PlayerUnit playerUnit)
    {
        _playerUnit = playerUnit;
    }
}
