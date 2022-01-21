using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public Animator animator;

    public float moveSpeed = 10f;
    private SpriteRenderer sprite;
    public Joystick joystick;

    public void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        float h = joystick.Horizontal;
        Vector3 movement = new Vector3(h, 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        animator.SetFloat("speed", Mathf.Abs(h));

        if (joystick.Horizontal > 0)
        {
            sprite.flipX = true;
        }
        else if (joystick.Horizontal < 0)
        {
            sprite.flipX = false;
        }

    }
}
