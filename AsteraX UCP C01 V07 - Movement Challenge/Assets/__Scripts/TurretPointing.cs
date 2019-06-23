using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPointing : MonoBehaviour
{

    private Vector3 pointingTarget;

    // Update is called once per frame
    void Update()
    {
        // Makes the turretn point to mouse position
        pointingTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
        transform.LookAt(pointingTarget, Vector3.back);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawSphere(pointingTarget, 0.2f);
        Gizmos.DrawLine(transform.position, pointingTarget);
    }
}