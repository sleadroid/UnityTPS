using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float lifeTime = 2f;
    private float bulletForce = 200f;

    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
        
        if (gameObject.name == "Bullet(Clone)")
            Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
