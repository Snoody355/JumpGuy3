using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int MaxHealthPoints;
    private int healthPoints;
    private bool isDead;


    public UnityEvent<int> OnHealthChaged;
    public UnityEvent OnDie;


    // Start is called before the first frame update
    void Start()
    {
        healthPoints = MaxHealthPoints;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damage(int damageCaused)
    {
        
        healthPoints -= damageCaused;
        OnHealthChaged.Invoke(healthPoints);
        if (healthPoints <= 0)
        {
           
           OnDie.Invoke();
           
        }
    }

    void Die()
    {
        isDead = true;
    }

    public bool amIDead()
    {
        return isDead;
    }
}
