using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeckgrounfLoop : MonoBehaviour
{
    [SerializeField] private float speed;
     private float value;
    
    Vector3 startPostion;

    // Start is called before the first frame update
    void Start()
    {
        startPostion = transform.position;
        value = GetComponent<BoxCollider2D>().size.x/ 2;
     }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPostion.x - value)
        {
            transform.position = startPostion;
        }

        transform.Translate(Vector3.left * speed * Time.deltaTime);

    }

    // test changes
    // test changes again

}
