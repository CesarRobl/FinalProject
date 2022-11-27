using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController cam;
    void Start()
    {
        cam = this;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(GameManager.pc.mousey,0,0);
    }
}
