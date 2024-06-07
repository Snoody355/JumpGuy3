using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColider : MonoBehaviour
{
    [SerializeField] private Collider2D GColider;

    public Collider2D ReturnCollider()
    {
        return GColider;
    }
}
