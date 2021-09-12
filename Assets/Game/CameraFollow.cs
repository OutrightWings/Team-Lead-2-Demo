using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject follow;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(follow.transform.position.x,0.15f,-10);
    }
}
