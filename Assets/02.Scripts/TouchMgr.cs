using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMgr : MonoBehaviour
{
    private Camera arCamera;
    private GameObject monster;

    // Start is called before the first frame update
    void Start()
    {
        arCamera = Camera.main;
        monster = Resources.Load<GameObject>("Monster");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
