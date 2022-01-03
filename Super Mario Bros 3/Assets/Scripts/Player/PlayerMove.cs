using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  public float runSpeed = 1f;
  public float jumpSpeed = 2f;
  public float runWithJump = 0.6f;
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
  void Update()
  {
    float speed = runSpeed;
    if(CheckGround.isTouchGround){
      animatior.SetBool("Jump", false);
      timeJump = 0f;
    }else{
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
    }
  }
}
