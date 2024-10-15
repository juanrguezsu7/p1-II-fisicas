using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seventh : MonoBehaviour
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
        transform.LookAt(sphere.transform);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
