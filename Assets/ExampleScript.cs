using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExampleScript : MonoBehaviour
{
    public float force;
    public Rigidbody rb;
    private Keyboard _keyboard;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _keyboard = Keyboard.current;
    }

    // Update is called once per frame
    void Update()
    {
        if (_keyboard.spaceKey.wasPressedThisFrame)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
