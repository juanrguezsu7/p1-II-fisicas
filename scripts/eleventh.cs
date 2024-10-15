using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eleventh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == "Cube") {
          Debug.Log("Objeto cinemático + rigidbody + collider: " + other.name + " ha colisionado con el objeto trigger.");
        }
        if (other.gameObject.name == "Sphere") {
          Debug.Log("Objeto físico puro + rigidbody + collider: " + other.name + " ha colisionado con el objeto trigger.");
        }
    }
}
