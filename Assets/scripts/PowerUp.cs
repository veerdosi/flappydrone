// using System.Collections;
// using System.Collections.Generic;
// using Unity.Mathematics;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private float speed = 5f;

    private float leftEdge;
    public AudioClip powerSound;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;

    }

    private void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
    public void PowerGranted()
    {
        FindObjectOfType<GameManager>().IncreasePackets();
        Destroy(gameObject);
        SoundManager.instance.PlaySound(powerSound);
    }
}
