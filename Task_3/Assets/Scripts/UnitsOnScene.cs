using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsOnScene : MonoBehaviour
{
    [SerializeField] private PlayerUnit playerUnitPrefab;
    [SerializeField] private EnemyUnit enemyUnitPrefab;

    private PlayerUnit _playerUnitRef;

    private void Start()
    {
        SpawnPlayer();
        StartCoroutine(EnemySpawnerEnumerator());
    }

    private void SpawnPlayer()
    {
        _playerUnitRef = Instantiate(playerUnitPrefab.gameObject).GetComponent<PlayerUnit>();

        _playerUnitRef.UnitsOnScene = this;
    }

    private IEnumerator EnemySpawnerEnumerator()
    {
        while (true)
        {
            var spawnedEnemyRef = Instantiate(enemyUnitPrefab.gameObject).GetComponent<EnemyUnit>();

            spawnedEnemyRef.PlayerUnit = _playerUnitRef;
            spawnedEnemyRef.UnitsOnScene = this;

            _playerUnitRef.EnemyUnits.Add(spawnedEnemyRef);

            yield return new WaitForSeconds(3f);
        }
    }
}
