using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaPlantAttack : MonoBehaviour
{
    public GameObject bullet;
    public float cooldown;
    private float timeWaiting;
    public float lifeTimeBullet;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponentInParent<Animator>();
        spriteRenderer = gameObject.GetComponentInParent<SpriteRenderer>();
        timeWaiting = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        timeWaiting += Time.deltaTime;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Vector3 playerPosition = collision.transform.position;

            // verify if the player is above of piranha
            if (Mathf.Abs(playerPosition.x - transform.position.x) < 2f)
            {
                animator.SetBool("topTop", true);
            } else if (playerPosition.x > transform.position.x)
            {
                animator.SetBool("topTop", false);
                spriteRenderer.flipX = true;
                if(playerPosition.y > transform.position.y)
                {
                    animator.SetBool("top", true);
                }
                else
                {
                    animator.SetBool("top", false);
                }
            } else
            {
                animator.SetBool("topTop", false);
                spriteRenderer.flipX = false;
                if (playerPosition.y > transform.position.y)
                {
                    animator.SetBool("top", true);
                }
                else
                {
                    animator.SetBool("top", false);
                }
            }
            
                if(timeWaiting >= cooldown/* && parentPosition.y > 0.8f*/)
            {
                ShootBullet.shoot(bullet, transform.position, playerPosition, transform.rotation, 120f, lifeTimeBullet);
                timeWaiting = 0f;
            }

        }
    }
}
