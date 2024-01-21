using UnityEngine;

public class StudentSpawner : MonoBehaviour
{
    public GameObject prefab2;
    public float spawnRate2 = 0.5f;

    public int numSpawn = 0;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate2, Random.Range(3, 7));
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject Students = Instantiate(prefab2, transform.position, Quaternion.identity);
        numSpawn++;
        if (numSpawn == 10)
        {
            FindObjectOfType<PowerSpawn>().StartPower();
            numSpawn = 0;
        }

    }
}
