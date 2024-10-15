using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eighth : MonoBehaviour
{
    public float rotateSpeed = 100.0f;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 5, Color.red); 
        float rotation = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * rotation * Time.deltaTime * rotateSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //
    }
}
