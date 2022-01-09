using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //public Animator animator;
    //private Rigidbody2D rb2D;
    //private BoxCollider2D bc2D;
    //public GameObject hitBox;
    public GameObject enemy;
    private void Start()
    {
        //rb2D = gameObject.GetComponent<Rigidbody2D>();
        //bc2D = gameObject.GetComponent<BoxCollider2D>();
    }
    public void HurtEnemy()
    {
        Instantiate(enemy, new Vector3(transform.position.x, transform.position.y, -1), transform.rotation);
        Destroy(gameObject);
    }

}
