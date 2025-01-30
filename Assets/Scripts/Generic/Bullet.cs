using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float maxDistance = 50f;
    void Start()
    {

        Destroy(gameObject, maxDistance / speed);
    }
    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
