using UnityEngine;

public class Students : MonoBehaviour
{
    public float speed = 5f;

    private float leftEdge;

    public GameObject prefab_ate;

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
            if (gameObject.tag == "student")
            {
                FindObjectOfType<GameManager>().Missed();
            }
        }
    }


    public void Vanish()
    {
        Destroy(gameObject);
        Instantiate(prefab_ate, transform.position, Quaternion.identity);
        prefab_ate.SetActive(true);
    }
}
