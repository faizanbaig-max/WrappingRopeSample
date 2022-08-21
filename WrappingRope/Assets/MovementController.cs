using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movemement();
    }
    void Movemement()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical"));
        rb.AddForce(movement);
    }
}
