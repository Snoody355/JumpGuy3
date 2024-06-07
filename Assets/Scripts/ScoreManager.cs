using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    private int Score;
    [SerializeField] private Health playerHealth;
    private float ScoreTime = 1f;
    public UnityEvent<int> OnScoreChaged;
    [SerializeField] private GameObject player;

    private bool idDead;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth.OnDie.AddListener(ImDead);
        idDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (idDead == false)
        {
            
            if (timer > ScoreTime)
            {
                Score++;
                OnScoreChaged.Invoke(Score);
                timer = 0;
            }
            
        }
        

        timer += Time.deltaTime;
        
    }

    void ImDead()
    {
        idDead = true;

    }


    public void UpdateScore(int addedScore)
    {
        Score += addedScore;
        OnScoreChaged.Invoke(Score);
    }
}
