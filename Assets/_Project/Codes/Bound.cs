using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
    private BoxCollider2D bound;
    private CameraManager cameraManager;

    private void Start()
    {
        bound = GetComponent<BoxCollider2D>();
        cameraManager = FindObjectOfType<CameraManager>();
        cameraManager.SetBound(bound);
    }
}
