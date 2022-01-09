using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject shoot(GameObject bullet, Vector3 from, Vector3 to, Quaternion rotation, float force, float time)
    {
        GameObject newBullet = Instantiate(bullet, new Vector3(from.x, from.y, 0), rotation);
        newBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(to.x - from.x, to.y - from.y).normalized * force);
        newBullet.GetComponent<Bullet>().Delete(time);
        return newBullet;
    }
}
