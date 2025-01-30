using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;


public class EnemyInputHandler : InputHandler
{
    [SerializeField] private Vector2 input;
    private void Update()
    {
        OnInput?.Invoke(input);
    }
}
