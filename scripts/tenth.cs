using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Cube") {
          Debug.Log("Objeto cinemático + rigidbody + collider: " + other.gameObject.name + " ha colisionado con el objeto.");
        }
        if (other.gameObject.name == "Sphere") {
          Debug.Log("Objeto físico puro + rigidbody + collider: " + other.gameObject.name + " ha colisionado con el objeto.");
        }
    }
}
