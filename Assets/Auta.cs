using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auta : MonoBehaviour
{
    [SerializeField] GameObject auto_0;
    [SerializeField] GameObject auto_1;
    float distanceX_0 = -108.5f;
    float distanceX_00 = -26.6f;
    float distanceX_1 = -26.4f;
    float distanceX_11 = -110.5f;
    float speed = 8f;
    bool lewo_0 = true;
    bool lewo_1 = false;
    bool prawo_0 = false;
    bool prawo_1 = true;

    void Update()
    {
        Auto0();
        Auto1();
    }

    void Auto0()
    {
        if (lewo_0) auto_0.transform.Translate(speed * Time.deltaTime * Vector2.left);
        if (prawo_0) auto_0.transform.Translate(speed * Time.deltaTime * Vector2.left);
        if(auto_0.transform.position.x <= distanceX_0)
        {
            lewo_0 = false;
            prawo_0 = true;
            auto_0.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (auto_0.transform.position.x >= distanceX_00)
        {
            lewo_0 = true;
            prawo_0 = false;
            auto_0.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
    void Auto1()
    {
        if (lewo_1) auto_1.transform.Translate(speed * Time.deltaTime * Vector2.left);
        if (prawo_1) auto_1.transform.Translate(speed * Time.deltaTime * Vector2.left);
        if (auto_1.transform.position.x >= distanceX_1)
        {
            lewo_1 = false;
            prawo_1 = true;
            auto_1.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (auto_1.transform.position.x <= distanceX_11)
        {
            lewo_1 = true;
            prawo_1 = false;
            auto_1.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }

}
