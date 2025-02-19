using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] Player player;
    bool one = false;

    private void Update()
    {
        if (player.gameStart)
        {
            if (!one)
            {
                gameObject.transform.position = new Vector3(-10.9f, 2.46f, -10);
                one = true;
            }
            gameObject.transform.SetParent(player.transform);
        }
    }

}
