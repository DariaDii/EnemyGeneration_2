using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;

    private float _delay = 10f;
    private bool _canSpawn = true;

    private void Start()
    {
        StartCoroutine(Spawn());
    }  

    private void SpawnEnemy()
    {
        Enemy enemyInstance = Instantiate(_enemyPrefab,transform.position,Quaternion.identity);
        enemyInstance.ChangeTarget(_target);
    }

    private IEnumerator Spawn()
    {
        var delay = new WaitForSeconds(_delay);

        while (_canSpawn)
        {
            SpawnEnemy();
            yield return delay;
        }                        
    }
}