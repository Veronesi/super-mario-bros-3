using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KoopaTroopaShield : MonoBehaviour
{
    public GameObject detectorLeft;
    public GameObject detectorRight;
    private Rigidbody2D rb2D;
    private float timeWaiting;
    public GameObject hitBox;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        timeWaiting = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        timeWaiting += Time.deltaTime;
        if (detectorRight.GetComponent<isCollision>().onPlayerCollision)
        {
            if (Mathf.Abs(rb2D.velocity.x) < 0.1f)
            {
                gameObject.GetComponent<HorizontalMoveFlip>().moveDirecction = "left";
                timeWaiting = 0f;
                hitBox.SetActive(false);
            }
            else if (timeWaiting > 0.5f)
            {
                hitBox.SetActive(true);
            }

        }
        else if (detectorLeft.GetComponent<isCollision>().onPlayerCollision)
        {
            if (Mathf.Abs(rb2D.velocity.x) < 0.1f)
            {
                gameObject.GetComponent<HorizontalMoveFlip>().moveDirecction = "right";
                timeWaiting = 0f;
                hitBox.SetActive(false);
            }
            else if (timeWaiting > 0.5f)
            {
                hitBox.SetActive(true);
            }
        }
    }
}