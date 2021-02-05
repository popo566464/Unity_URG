using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 1024, true);
        //MirrorFlipCamera(this.gameObject.GetComponent<Camera>());
    }

    void MirrorFlipCamera(Camera camera)
    {

        Matrix4x4 mat = camera.projectionMatrix;

        mat *= Matrix4x4.Scale(new Vector3(-1, 1, 1));

        camera.projectionMatrix = mat;

    }


}
