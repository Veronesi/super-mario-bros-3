using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb2D;
    private BoxCollider2D bc2D;
    public GameObject hitBox;
    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        bc2D = gameObject.GetComponent<BoxCollider2D>();
    }
    public void HurtEnemy()
    {
        Destroy(hitBox);
        animator.Play("Hurt");
        rb2D.velocity = Vector2.zero;
        rb2D.isKinematic = true;
        Destroy(bc2D);
        Invoke("DestroySelf", 0.5f);
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
