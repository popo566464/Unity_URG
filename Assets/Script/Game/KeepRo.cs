using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepRo : MonoBehaviour
{

    void Update()
    {
        gameObject.transform.Rotate(0, 0, 30 * Time.deltaTime);
    }
}
