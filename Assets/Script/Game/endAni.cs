using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endAni : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float durationtime = 1;
    float x, Timecount;
    public Vector3 targetScale, EndScale;

    void Start()
    {
        targetScale = new Vector3(-0.01f, 0.01f, 0.01f);
        EndScale = new Vector3(-0.0005f, 0.0005f, 0.0005f);
        this.transform.localScale = new Vector3(-0.0005f, 0.0005f, 0.0005f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timecount < 3f)
        {
            Timecount += Time.deltaTime;
            x = Time.deltaTime / durationtime;
            this.transform.localScale = Vector3.Lerp(this.transform.localScale, targetScale, curve.Evaluate(x));
        }
        else
        {
            this.transform.localScale = Vector3.Lerp(this.transform.localScale, EndScale, curve.Evaluate(x));
            GameObject.Destroy(gameObject, 2f);
        }
    }
}
