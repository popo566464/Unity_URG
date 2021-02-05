using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Light")
        {
            int r = Random.Range(0, 6);
            GameObject.Destroy(other.gameObject);
            GameObject.Instantiate(Resources.Load<GameObject>(string.Format("tr{0}", r))).transform.position = other.gameObject.transform.position;
            
        }
    }
}
