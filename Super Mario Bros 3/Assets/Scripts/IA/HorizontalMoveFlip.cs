using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMoveFlip : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity;
    private string LEFT = "left";
    private string RIGHT = "right";
    public GameObject detectorLeft;
    public GameObject detectorRight;
    public string moveDirecction;
    private Rigidbody2D rb2D;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        if(moveDirecction == LEFT || moveDirecction == RIGHT)
        {
            spriteRenderer.flipX = moveDirecction == LEFT;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(moveDirecction == RIGHT)
        {
            if (detectorRight.GetComponent<isCollision>().onGroundCollision)
            {
                moveDirecction = LEFT;
                spriteRenderer.flipX = false;
            }
            else
            {
                rb2D.velocity = new Vector2(velocity, rb2D.velocity.y);
            }
        }
        else if(moveDirecction == LEFT)
        {
            if (detectorLeft.GetComponent<isCollision>().onGroundCollision)
            {
                moveDirecction = RIGHT;
                spriteRenderer.flipX = true;
            }
            else
            {
                rb2D.velocity = new Vector2(-velocity, rb2D.velocity.y);
            }
        } else
        {
            if (detectorRight.GetComponent<isCollision>().onGroundCollision)
            {
                moveDirecction = LEFT;
            }else if (detectorLeft.GetComponent<isCollision>().onGroundCollision)
            {
                moveDirecction = RIGHT;
            }
        }
    }
}
