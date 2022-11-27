using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public static PlayerController pc;
    public static EnemyController ec;

    [HideInInspector]public float walkdelay, sensitive = 3;
    void Start()
    {
        gm = this;
        SetValues();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetValues()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        walkdelay = 4;
    }
}
