using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontallMove : MonoBehaviour
{
    public float velocity = 0f;
    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(velocity, rb2D.velocity.y);
    }
}
