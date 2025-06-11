using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float knockbackMod;

    private ParticleSystem pSys;
    private Rigidbody2D rb;

    [SerializeField]
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        pSys = GetComponentInChildren<ParticleSystem>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.LookAt(new Vector3(player.position.x * 2, gameObject.transform.position.y, gameObject.transform.position.z), Vector2.up);
        //gameObject.transform.rotation = Quaternion.Euler(0, (player.position.x - gameObject.transform.position.x)/2, 0);
    }

    public void TakeDamage(Vector2 attackedFromPos)
    {
        Vector2 dir = (attackedFromPos - (Vector2)gameObject.transform.position).normalized;
        Debug.DrawRay(gameObject.transform.position, -dir, Color.red, 10f);

        rb.AddForce((-dir * knockbackMod) + Vector2.up, ForceMode2D.Impulse);
        pSys.Play();
        
    }
}
