using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �ٸ� ������ ������ �̵��Ҷ� ���̴� �޼ҵ�
/// </summary>
public class TransformScene : MonoBehaviour
{
    public string transformMapName;

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
        if (collision.gameObject.name == "Character")
        {
            player.currentMapName = transformMapName;
            SceneManager.LoadScene(transformMapName);
        }
    }
}
