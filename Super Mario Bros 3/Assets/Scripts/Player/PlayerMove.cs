using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  public float runSpeed = 8f;
  public float jumpSpeed = 8f;
  public float runWithJump = 2f;
  public float maxTimeJump = 0.4f;
  public float timeJump;
  public Animator animatior;
  public SpriteRenderer spriteRenderer;
  Rigidbody2D rb2D;
  // Start is called before the first frame update
  void Start()
  {
    rb2D = GetComponent<Rigidbody2D>();
    timeJump = 0f;
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    float speed = runSpeed;
    if(CheckGround.isTouchGround){
      animatior.SetBool("Jump", false);
      timeJump = 0f;
    }

    if(rb2D.velocity.y > 0.1f || rb2D.velocity.y < -0.1f){
      speed = runWithJump;
    }

    if (Input.GetKey("w") && timeJump <= maxTimeJump)
    {
      timeJump += Time.deltaTime;
      animatior.SetBool("Jump", true);
      rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
    }
    if (Input.GetKey("d"))
    {
      animatior.SetBool("Run", true);
      // verify is jumping 
      rb2D.velocity = new Vector2(speed, rb2D.velocity.y);
      spriteRenderer.flipX = false;
    }
    else if (Input.GetKey("a"))
    {
      animatior.SetBool("Run", true);
      rb2D.velocity = new Vector2(-speed, rb2D.velocity.y);
      spriteRenderer.flipX = true;
    }
    else
    {
      animatior.SetBool("Run", false);
      rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
  }
}
