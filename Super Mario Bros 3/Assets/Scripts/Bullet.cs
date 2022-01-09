using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IBullet
{
    public void Delete(float time)
    {
        Invoke("deleteGameObject", time);
    }
    private void deleteGameObject()
    {
        Destroy(gameObject);
    }
}
