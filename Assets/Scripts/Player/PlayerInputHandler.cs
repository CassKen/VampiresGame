using UnityEngine;

public class PlayerInputHandler : InputHandler
{
    private void Update()
    {
        OnInput?.Invoke(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetButtonDown("Fire1"))
        {
            OnShoot?.Invoke();
        }
    }
}
