using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalRandomMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeMin;
    public float timeMax;
    private float timeWait;
    private float timeSelected;
    public float velocity;
    private string LEFT = "left";
    private string RIGHT = "right";
    public string moveDirecction;
    private Rigidbody2D rb2D;
    private SpriteRenderer spriteRenderer; 
    void Start()
    {
        timeWait = 0f;
        timeSelected = Random.Range(timeMin, timeMax);
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        spriteRenderer.flipX = moveDirecction == LEFT;
    }

    // Update is called once per frame
    void Update()
    {
        timeWait += Time.deltaTime;
        if (timeSelected <= timeWait)
        {
            timeSelected = Random.Range(timeMin, timeMax);
            timeWait = 0f;
            if (moveDirecction == LEFT)
            {
                moveDirecction = RIGHT;
                spriteRenderer.flipX = false;
            }
            else
            {
                moveDirecction = LEFT;
                spriteRenderer.flipX = true;
            }
        }
        else
        {
            if (moveDirecction == LEFT)
            {
                rb2D.velocity = new Vector2(velocity, rb2D.velocity.y);
            }
            else
            {
                rb2D.velocity = new Vector2(-velocity, rb2D.velocity.y);
            }
        }
    }
}
