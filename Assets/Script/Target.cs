using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Target : MonoBehaviour
{
    public event Action Hit;

    [SerializeField] private LayerMask targetLayerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == targetLayerMask)
        {
            Hit?.Invoke();
        }

        Destroy(gameObject);
    }
}
