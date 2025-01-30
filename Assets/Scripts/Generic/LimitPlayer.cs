using UnityEngine;

public class LimitPlayer : MonoBehaviour
{
    [SerializeField] private Transform limitUp;
    [SerializeField] private Transform limitDown;

    private void LateUpdate()
    {
        var limitUpPosition = limitUp.position.z;
        var limitDownPosition = limitDown.position.z;
        var limitRightPosition = limitDown.position.x;
        var limitLeftPosition = limitUp.position.x;
        var playerPosition = transform.position;

        if (playerPosition.z < limitDownPosition)
        {
            playerPosition.z = limitDownPosition;
        }
        if (playerPosition.z > limitUpPosition)
        {
            playerPosition.z = limitUpPosition;
        }
        if (playerPosition.x > limitRightPosition)
        {
            playerPosition.x = limitRightPosition;
        }
        if (playerPosition.x < limitLeftPosition)
        {
            playerPosition.x = limitLeftPosition;
        }

        transform.position = playerPosition;
    }
}
