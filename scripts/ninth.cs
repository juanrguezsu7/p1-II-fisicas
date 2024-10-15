using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere" || other.name == "Cube")
        {
            Debug.Log("Objeto " + other.name + " ha activado el trigger.");
        }
    }
}
