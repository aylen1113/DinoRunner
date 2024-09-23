using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform spawnPoint; 
    public float spawnInterval = 2f;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            GameObject obstacle = ObjectPool.Instance.GetObjectFromPool();
            obstacle.transform.position = spawnPoint.position; 
        }
    }
}
