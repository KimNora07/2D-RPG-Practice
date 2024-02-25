using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� ������ ������ �̵��Ҷ� ���̴� �޼ҵ�
/// </summary>
public class TransformMap : MonoBehaviour
{
    public Transform target;
    private MovingObject player;
    private CameraManager cameraManager;

    private void Start()
    {
        player = FindObjectOfType<MovingObject>();
        cameraManager = FindObjectOfType<CameraManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Character")
        {
            player.transform.position = target.transform.position;
            cameraManager.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, cameraManager.transform.position.z);
        }
    }
}
