using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hozionztalInput;
    public float speed = 10.0f;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       

    }

    // Update is called once per frame
    void Update() 
    {
        hozionztalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hozionztalInput * Time.deltaTime * speed);
    }
}
