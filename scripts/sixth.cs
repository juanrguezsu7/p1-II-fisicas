using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sixth : MonoBehaviour
{
    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = sphere.transform.position - transform.position;
        movement.Normalize();
        movement = new Vector3(movement.x, 0, movement.z);
        transform.Translate(movement * Time.deltaTime, Space.World);
    }
}
