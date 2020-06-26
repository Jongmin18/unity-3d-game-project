using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float rotSpeed = 2;
    bool left = false;
    bool right = false;
    float rotDegree = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isStartGame)
        {
            CheckKey();

            if (left == true)
            {
                transform.Rotate(0, -rotSpeed, 0);
                rotDegree -= rotSpeed;
            }
            else if (right == true)
            {
                transform.Rotate(0, rotSpeed, 0);
                rotDegree += rotSpeed;
            }
        }
    }

    void CheckKey()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (rotDegree == 0)
            {
                left = true;
            }
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (rotDegree == 0)
            {
                right = true;
            }
        }

        if (rotDegree <= -90)
        {
            left = false;
            rotDegree = 0;
        }
        else if (rotDegree >= 90)
        {
            right = false;
            rotDegree = 0;
        }
    }
}
