using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    // References
    Animator am;
    EnemyMovement em;
    SpriteRenderer sr;

    void Start()
    {
        am = GetComponent<Animator>();
        em = GetComponent<EnemyMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 moveDirection = (em.PlayerPosition - (Vector2)transform.position).normalized;

        if (moveDirection.x != 0 || moveDirection.y != 0)
        {
            am.SetBool("Move", true);
            SpriteDirectionChecker(moveDirection);
        }
        else
        {
            am.SetBool("Move", false);
        }
    }

    void SpriteDirectionChecker(Vector2 moveDirection)
    {
        if (moveDirection.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}
