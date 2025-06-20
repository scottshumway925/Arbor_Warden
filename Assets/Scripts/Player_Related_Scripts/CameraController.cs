using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform followTarget;
    [SerializeField] float cameraDistance = 5;

    private void Update()
    {
        transform.position = followTarget.position - new Vector3(0, 0, cameraDistance);
    }
}
