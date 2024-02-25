using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public string startPointName;

    private MovingObject player;
    private CameraManager cameraManager;

    private void Start()
    {
        player = FindObjectOfType<MovingObject>();
        cameraManager = FindObjectOfType<CameraManager>();

        if(startPointName == player.currentMapName)
        {
            cameraManager.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, cameraManager.transform.position.z);
            player.transform.position = this.transform.position;
        }
    }
}
