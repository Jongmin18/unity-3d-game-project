using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float noteSpeed = 2;
    public bool updown = true;
    public bool increase = false;

    UnityEngine.UI.Image noteImage;

    void Start()
    {
        noteImage = GetComponent<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (updown == true && increase == false)
        {
            transform.position += Vector3.back * noteSpeed * Time.deltaTime;
        }
        else if (updown == true && increase == true)
        {
            transform.position += Vector3.forward * noteSpeed * Time.deltaTime;
        }
        else if (updown == false && increase == false)
        {
            transform.position += Vector3.left * noteSpeed * Time.deltaTime;
        }
        else if (updown == false && increase == true)
        {
            transform.position += Vector3.right * noteSpeed * Time.deltaTime;
        }
    }

    public void HideNote()
    {
        noteImage.enabled = false;
    }

}
