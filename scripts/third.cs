using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third : MonoBehaviour
{
    public Vector3 moveDirection;
    public float velocity = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * velocity * Time.deltaTime, Space.World);
    }
}
