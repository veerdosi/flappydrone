using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public Transform DropPoint;
    public GameObject packPrefab;
    public AudioClip deliverSound;

    [Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            droppack();
        }
    }

    [Obsolete]
    void droppack()
    {
        Instantiate(packPrefab, DropPoint.position, DropPoint.rotation);
        FindObjectOfType<GameManager>().Packets();
        SoundManager.instance.PlaySound(deliverSound);
    }

}
