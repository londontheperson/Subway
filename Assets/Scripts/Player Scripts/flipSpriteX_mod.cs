using UnityEngine;
using UnityEngine.InputSystem;

public class flipSpriteX_mod : MonoBehaviour
{
    public SpriteRenderer sprite;

    public KeyCode LeftKey = KeyCode.A;
    public KeyCode RightKey = KeyCode.D;

    //Update is called once per frame
    void Update()
    {
        if (!sprite) return;

        if (Input.GetKey(LeftKey))
        {
            sprite.flipX = true;
        }
        else if (Input.GetKey(RightKey))
        {
            sprite.flipX = false;
        }
    }
}
