using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : TurnTakerController
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.ec = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
