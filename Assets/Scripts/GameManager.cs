using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    [SerializeField] private GameObject[] coinPrefabs;
    [SerializeField] private Transform[] coinSpawnPoints;

    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoinsCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCoinsCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Transform randomPoint = coinSpawnPoints[Random.Range(0, coinSpawnPoints.Length)];
            Vector2 randomPosition = Random.insideUnitCircle * 1f;
            GameObject randomcoin = coinPrefabs[Random.Range(0, coinPrefabs.Length)];
            GameObject tempCoins = Instantiate(randomcoin, randomPosition, Quaternion.identity);
        }
    }
}
