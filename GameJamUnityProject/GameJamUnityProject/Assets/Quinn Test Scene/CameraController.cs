using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float smoothing = 6f;
    public Transform lookAtTarget;
    public Transform positionTarget;

    private void FixedUpdate()
    {
        UpdateCamera();
    }

    private void UpdateCamera()
    {
        transform.position = Vector3.Lerp(transform.position, positionTarget.position, Time.deltaTime * smoothing);
        transform.LookAt(lookAtTarget);
    }
}
