using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{
    public double velocity = 0.0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0) {
          Debug.Log("Up arrow: " + Input.GetAxis("Vertical") * velocity);
        }
        if (Input.GetAxis("Vertical") < 0) {
          Debug.Log("Down arrow: " + Input.GetAxis("Vertical") * velocity);
        }
        if (Input.GetAxis("Horizontal") > 0) {
          Debug.Log("Right arrow: " + Input.GetAxis("Horizontal") * velocity);
        }
        if (Input.GetAxis("Horizontal") < 0) {
          Debug.Log("Left arrow: " + Input.GetAxis("Horizontal") * velocity);
        }
    }
}
