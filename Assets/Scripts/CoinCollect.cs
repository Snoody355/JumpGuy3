using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private ScoreManager scoreM;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreM.UpdateScore(1);
        Destroy(coin);

    }

    // Start is called before the first frame update
    void Start()
    {
        scoreM = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyCollectable();
    }


    void DestroyCollectable()
    {
        Destroy(coin, 50f);
    }
}
