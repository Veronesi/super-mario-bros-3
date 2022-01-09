using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isCollision : MonoBehaviour
{
    public bool onGroundCollision = false;
    public bool onPlayerCollision = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            onGroundCollision = true;
        }
        if (collision.CompareTag("Player"))
        {
            onPlayerCollision = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            onGroundCollision = false;
        }
        if (collision.CompareTag("Player"))
        {
            onPlayerCollision = false;
        }
    }
}
