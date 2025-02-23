using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
{
    Camera cam;
    [SerializeField] Player player;
    bool one = false;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        if (player.gameStart)
        {
            if (!one)
            {
                gameObject.transform.position = new Vector3(-10.9f, 2.46f, -10);
                one = true;
            }
            //gameObject.transform.SetParent(player.transform);
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -9);
        }
    }

}
