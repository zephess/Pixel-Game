using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    enum State { Patrolling, Chasing };
    [SerializeField]
    private Transform player, point1, point2, currentPoint;

    private Rigidbody2D rb;
    private State state;
    [SerializeField]
    private float speed;
    private bool canJump;
    private float characterHeight;
    [SerializeField]
    private LayerMask characterMask;

    [SerializeField]
    private float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        state = State.Patrolling;
        rb = GetComponent<Rigidbody2D>();
        characterHeight = GetComponent<SpriteRenderer>().bounds.size.y;
        currentPoint = point1;
    }

    // Update is called once per frame
    void Update()
    {

        //Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 3f);
        
        if(Vector2.Distance(transform.position, player.position) < 3f )
        {
            state = State.Chasing;
        }
        else
        {
            state = State.Patrolling;
            //currentPoint = point1;
        }
        if (Physics2D.Raycast(rb.gameObject.transform.position, Vector2.down, (characterHeight / 2) + 0.2f, characterMask))
        {
            //Debug.Log("Grounded");
            canJump = true;
        }
        else
        {
            canJump = false;
        }
        if (state == State.Patrolling)
        {
            if (transform.position.x < currentPoint.position.x)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (currentPoint == point1)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(point1.position.x, transform.position.y), speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(point2.position.x, transform.position.y), speed * Time.deltaTime);
            }

            if (Vector2.Distance(rb.transform.position, currentPoint.position) < 0.5f && currentPoint == point1)
            {
                //flip();
                currentPoint = point2;
            }

            if (Vector2.Distance(rb.transform.position, currentPoint.position) < 0.5f && currentPoint == point2)
            {
                //flip();
                currentPoint = point1;
            }
        }

        else
        {
            if(transform.position.x < player.position.x)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), speed * Time.deltaTime);
            if(player.position.y > transform.position.y + 1 && Vector2.Distance(rb.transform.position, player.position) < 2)
            {
                jump();
            }
        }
       
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(point1.position, 0.5f);
        Gizmos.DrawSphere(point2.position, 0.5f);
        Gizmos.DrawLine(point1.position, point2.position);
        Gizmos.DrawSphere(transform.position, 3f);
    }

    private void flip()
    {
        Vector2 transform = gameObject.transform.localScale;
        transform.x *= -1;
        gameObject.transform.localScale = transform;
    }

    private void jump()
    {
        if(canJump)
        {
           
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
