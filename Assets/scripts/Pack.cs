using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pack : MonoBehaviour
{
    void Start()
    {
        rb.velocity = transform.right * 0f;
    }
    public Rigidbody2D rb;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Students student = hitInfo.GetComponentInChildren<Students>();
        if (student != null)
        {
            student.Vanish();
            Destroy(gameObject);
        }
    }
}
