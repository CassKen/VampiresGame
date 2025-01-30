using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyCollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Bullet":
                Destroy(other.gameObject);                
                break;
        }
    }
}
