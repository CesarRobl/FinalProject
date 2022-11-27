using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeController : MonoBehaviour
{
    
    private bool down;
    public Vector3 pos;
    private float y_axis, distspeed;
    void Start()
    {
       
        y_axis = -.7f;
        distspeed = 2;
    }

    
    void Update()
    {
        pos = transform.position + new Vector3(0, y_axis, 0);
        StartCoroutine(CameraFloat());
    }

    

    IEnumerator CameraFloat()
    {
        if (!down)
        {
            transform.position =
                Vector3.MoveTowards(transform.position, pos , distspeed * Time.deltaTime);
            if (transform.position == pos)
            {
                y_axis = .7f;
                down = true;
            }
        }

        yield return new WaitForSeconds(.1f);
        
        if (down)
        {
            transform.position =
                Vector3.MoveTowards(transform.position, pos, distspeed * Time.deltaTime);
            if (transform.position == pos)
            {
                y_axis = -.7f;
                down = false;
            }
        }
        
    }
}
