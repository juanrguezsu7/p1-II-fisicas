using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twel : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rb.AddForce(movement * speed);
        // rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
    }
}
