using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
        {
            return;
        }

        Vector2 move = Vector2.zero;

        if (keyboard.wKey.isPressed)
        {
            move.y += 1;
        }

        if (keyboard.sKey.isPressed)
        {
            move.y -= 1;
        }
        if (keyboard.aKey.isPressed)
        {
            move.x -= 1;
        }
        if (keyboard.dKey.isPressed)
        {
            move.x += 1;
        }

        move = move.normalized;

        transform.Translate(move * speed * Time.deltaTime);
    }
}
