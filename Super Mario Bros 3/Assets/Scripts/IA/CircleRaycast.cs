using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CircleRaycast : MonoBehaviour
{
    //public float distance;
    public float radius;
    public UnityEvent customEvent;
    // Start is called before the first frame update
    private void Start()
    {
        transform.GetComponent<CircleCollider2D>().radius = radius;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            customEvent.Invoke();
        }
    }
}
