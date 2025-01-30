using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float timeToShoot = 0.3f;
    [SerializeField] private Transform bulletSpawnPoint;

    private float currentTime = 0f;

    public void Shoot()
    {
        if (currentTime <= Time.timeSinceLevelLoad)
        {
            Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        }
    }
}
