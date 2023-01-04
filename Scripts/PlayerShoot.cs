using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Rigidbody bullet;
    private float rof = 0.3f;
    private bool canFire = true;

    void Update()
    {
        if (Input.GetButton("Fire1") && canFire == true)
        {
            StartCoroutine(fireRate());
        }
    }

    // Sets delay between bullet spawn
    IEnumerator fireRate()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        canFire = false;
        yield return new WaitForSeconds(rof);
        canFire = true;
    }
}
