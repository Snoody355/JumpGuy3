using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime;
    [SerializeField] private float spawnRange;
    [SerializeField] private GameObject[] platform;
    [SerializeField] private bool stayonFloor;

    private float Timer;

    private void Start()
    {
        SpawnPlatform();
    }

    private void Update()
    {
        if(Timer > maxTime)
        {
            SpawnPlatform();
            Timer = 0;
        }

        Timer += Time.deltaTime;
    }

    private void SpawnPlatform()
    {
        if (!stayonFloor) {

            Vector3 spawn = transform.position + new Vector3(0, Random.Range(-spawnRange, spawnRange));
            GameObject randomObject = platform[Random.Range(0, platform.Length)];
            GameObject ground = Instantiate(randomObject, spawn, Quaternion.identity);
            Destroy(ground, 30f);

        }

        if (stayonFloor)
        {
            Vector3 spawn = transform.position;
            GameObject randomObject = platform[Random.Range(0, platform.Length)];
            GameObject ground = Instantiate(randomObject, spawn, Quaternion.identity);
            Destroy(ground, 30f);
        }


        

       
    }
}
