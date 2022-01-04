using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
  public static bool isTouchGround;
  public int[] listGround;
  public int numberTriggers;
  private void Start()
  {
    isTouchGround = false;
    numberTriggers = 0;
  }
  private void OnTriggerEnter2D(Collider2D collider)
  {
    if (collider.CompareTag("Ground"))
    {
      numberTriggers += 1;
      isTouchGround = true;
    }
  }
  private void OnTriggerExit2D(Collider2D collider)
  {
    if (collider.CompareTag("Ground"))
    {
      numberTriggers -= 1;
      if (numberTriggers == 0)
      {
        isTouchGround = false;
      }
    }
  }
}
