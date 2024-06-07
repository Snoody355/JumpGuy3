using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    private Health playerHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerHealth.Damage(1);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
