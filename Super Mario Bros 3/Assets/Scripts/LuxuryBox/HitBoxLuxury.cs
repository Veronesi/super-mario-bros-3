using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxLuxury : MonoBehaviour
{
    public GameObject luxuryBox;
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Player")){
            animator.Play("Hit");
            Invoke("Hit", 0.2f);
        }
    }
    private void Hit()
    {
        Destroy(luxuryBox);
    }
}
