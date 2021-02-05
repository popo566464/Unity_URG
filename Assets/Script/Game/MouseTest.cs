using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTest : MonoBehaviour
{
    Vector3 vect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gameObject.GetComponent<TrailRenderer>().enabled = true;
            vect = Input.mousePosition;
            vect.z = 0.994f;
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(vect);
        }
        else
        {
            gameObject.GetComponent<TrailRenderer>().enabled = false;
            gameObject.transform.position = new Vector3(0.005f, 0.005f, 0.15f);
        }
    }
}
