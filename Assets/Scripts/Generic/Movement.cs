using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    // Update is called once per frame
    public void Move(Vector2 input)
    {
        transform.Translate(input.x * speed * Time.deltaTime, 0, input.y * speed * Time.deltaTime);
    }
}
