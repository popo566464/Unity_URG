using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Ani : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float durationtime = 1;
    float x, Timecount;
    public Vector3 targetScale, EndScale;
    bool ani = false;

    void Start()
    {

        targetScale = new Vector3(-0.01f, 0.01f, 0.01f);
        EndScale = new Vector3(-0.0005f, 0.0005f, 0.0005f);
        this.transform.localScale = new Vector3(-0.0005f, 0.0005f, 0.0005f);
    }

    // Update is called once per frame
    void Update()
    {
        Timecount += Time.deltaTime;
        if (Timecount < 3f)
        {
            ani = false;
            x = Time.deltaTime / durationtime;
            this.transform.localScale = Vector3.Lerp(this.transform.localScale, targetScale, curve.Evaluate(x));
            if (gameObject.transform.localScale.x < -0.008f) { ani = true; }
        }
        if (Timecount > 6f)
        {
            this.transform.localScale = Vector3.Lerp(this.transform.localScale, EndScale, curve.Evaluate(x));
            GameObject.Destroy(gameObject, 2f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {     
        if (other.tag == "Touch")
        {
            
            Vector3 pos = gameObject.transform.position;
            if (ani)
            {
                switch (gameObject.tag)
                {
                    case "tr0":                  
                        GameObject.Instantiate(Resources.Load<GameObject>("Dtr0")).transform.position = pos;
                        break;
                    case "tr1":
                        GameObject.Instantiate(Resources.Load<GameObject>("Dtr1")).transform.position = pos;
                        break;
                    case "tr2":
                        GameObject.Instantiate(Resources.Load<GameObject>("Dtr2")).transform.position = pos;
                        break;
                    case "tr3":
                        GameObject.Instantiate(Resources.Load<GameObject>("Dtr3")).transform.position = pos;
                        break;
                    case "tr4":
                        GameObject.Instantiate(Resources.Load<GameObject>("Dtr4")).transform.position = pos;
                        break;
                    case "tr5":
                        GameObject.Instantiate(Resources.Load<GameObject>("Dtr5")).transform.position = pos;
                        break;
                }
                GameObject.Destroy(gameObject);
               
            }
        }
    }

}
