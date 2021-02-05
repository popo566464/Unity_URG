using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    float v;
    void Start()
    {
        v = Random.Range(0.10f, 0.20f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, v * Time.deltaTime, 0);
    }
}
