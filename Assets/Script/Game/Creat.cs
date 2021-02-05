using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Creat : MonoBehaviour
{
    public GameObject Cube;
    GameObject objcube;
    float n;
    public float[] pos;

    void Start()
    {
        pos = new float[13] { -0.6f, -0.5f, -0.4f, -0.3f, -0.2f, -0.1f, 0, 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f };
    }

    // Update is called once per frame
    void Update()
    {
        n = n + Time.deltaTime;
        if (n > 1.5f)
        {
            int posR = Random.Range(0,12);
            float scale = Random.Range(0.007f, 0.01f);
            objcube = GameObject.Instantiate(Cube);
            objcube.transform.position = new Vector3(pos[posR], 0.005f, 0);
            objcube.transform.localScale = new Vector3(scale, scale, scale);
            //objcube.GetComponent<Rigidbody>().AddForce(Random.Range(-100, 100), Random.Range(1000, 1200), 0);
            //objcube.GetComponent<Rigidbody>().AddTorque(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
            objcube.SetActive(true);       
            GameObject.Destroy(objcube, 15f);
            n = 0;
        }
    }
}
