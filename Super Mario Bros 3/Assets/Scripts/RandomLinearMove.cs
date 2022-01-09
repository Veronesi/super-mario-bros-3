using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLinearMove : MonoBehaviour
{
    public Transform position1;
    public Transform position2;
    public float timeMin;
    public float timeMax;
    private float timeWait;
    private float timeSelected;
    public float velocity;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        timeWait = 0f;
        timeSelected = Random.Range(timeMin, timeMax);
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeWait += Time.deltaTime;
        if(timeSelected <= timeWait)
        {
            bool isArrived = false;
            if(i == 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, position2.position, velocity);
                isArrived = Vector3.Distance(transform.position, position2.position) < 0.1f;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, position1.position, velocity);
                isArrived = Vector3.Distance(transform.position, position1.position) < 0.1f;
            }

            // generate a new timeSelected
            if (isArrived)
            {
                timeSelected = Random.Range(timeMin, timeMax);
                timeWait = 0f;
                if(i == 0)
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
            }
        }
    }
}
