using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpawn : MonoBehaviour
{
    public GameObject Power;
    public float spawnRate3 = 1f;

    public void StartPower()
    {
        Appear();
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Appear));
    }

    public void Appear()
    {
        GameObject PowerUp = Instantiate(Power, transform.position, Quaternion.identity);
        Debug.Log("This function was called");
    }
}
