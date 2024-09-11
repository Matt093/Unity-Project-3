using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Vector2 targetPos;
    public float dashrange;
    public float speed;
    private Vector2 direction;
    private Animator animator;
    private enum Facing { UP,DOWN,LEFT,RIGHT};
    private Facing facingDir = Facing.DOWN;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        TakeInput();
        Move();
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (direction.x !=0 || direction.y != 0)
        {
            SetAnimatorMovement(direction);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
    }

    private void TakeInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
            facingDir = Facing.UP;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            facingDir = Facing.LEFT;

        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            facingDir = Facing.DOWN;

        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            facingDir = Facing.RIGHT;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 currentPos = transform.position;
            targetPos = Vector2.zero;
            if(facingDir == Facing.UP)
            {
                targetPos.y = 1;
            }

            else if(facingDir == Facing.DOWN)
            {
                targetPos.y = -1;
            }
            else if (facingDir == Facing.LEFT)
            {
                targetPos.x = -1;
            }
            else if (facingDir == Facing.RIGHT)
            {
                targetPos.x = 1;
            }

            transform.Translate(targetPos * dashrange);



        }
    }

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetLayerWeight(1, 1);
        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("yDir", direction.y);
    }

}
