using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isTouchGround;
    private void Start() {
        isTouchGround = false;
    }
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Ground")){
            isTouchGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collider) {
        if(collider.CompareTag("Ground")){
            isTouchGround = false;
        }  
    }
}
