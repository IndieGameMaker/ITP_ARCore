using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class TouchMgr : MonoBehaviour
{
    private Camera arCamera;
    private GameObject monster;
    private TrackableHit hit;
    private TrackableHitFlags flags = TrackableHitFlags.Default;

    public bool isCreateDrone = false;

    // Start is called before the first frame update
    void Start()
    {
        arCamera = Camera.main;
        monster = Resources.Load<GameObject>("Drone");
    }

    // Update is called once per frame
    void Update()
    {
        if (isCreateDrone == true) return;
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began
            && Frame.Raycast(touch.position.x, touch.position.y, flags, out hit))
        {
            var anchor = hit.Trackable.CreateAnchor(hit.Pose);
            Instantiate(monster, hit.Pose.position, hit.Pose.rotation, anchor.transform);
            isCreateDrone = true;
        }
    }
}
