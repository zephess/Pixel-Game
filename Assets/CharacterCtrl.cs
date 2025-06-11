using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterCtrl : MonoBehaviour
{
    private float xVelocity;
    private float yVelocity;
    private Rigidbody2D rb;

    [SerializeField]
    private float velMult;

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private LayerMask playerMask, enemyMask;
 

    private float playerHeight;
    private bool canJump;
    private ParticleSystem pSys;

    [SerializeField]
    private float attackRange;

    [SerializeField]
    private Transform attackPos;

    [SerializeField]
    private int damage;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerHeight = GetComponent<SpriteRenderer>().bounds.size.y;
        pSys = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.Raycast(rb.gameObject.transform.position, Vector2.down, (playerHeight / 2) + 0.2f, playerMask))
        {
            //Debug.Log("Grounded");
            canJump = true;
        }
        else
        {
            canJump = false;
        }
        Debug.DrawRay(rb.gameObject.transform.position, Vector2.down * ((playerHeight / 2) +0.2f ), Color.red);
        if(xVelocity > 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if(xVelocity < 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, -180, 0); ;
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(xVelocity * Time.deltaTime * velMult, yVelocity * Time.deltaTime * velMult), ForceMode2D.Force);
        
    }

    private void OnMovement(InputValue _value)
    {
        //Debug.Log(_value.Get<float>());
        xVelocity = _value.Get<float>();
        //yVelocity = _value.Get<Vector2>().y;
    }

    private void OnJump(InputValue _value)
    {
        if(canJump)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        //rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        //Debug.Log("Jump");
        // = true;
    }

    private void OnAttack(InputValue _value)
    {
        Debug.Log("Attack");
        //pSys.Play();
        Collider2D[] enemiesHit = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemyMask);
        for (int i = 0; i < enemiesHit.Length; i++)
        {
            enemiesHit[i].GetComponent<Enemy>().TakeDamage(gameObject.transform.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}
