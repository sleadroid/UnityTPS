using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 10f;
    private float enemyDamage = 1f;
    private bool invulnerable = false;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Bullet" && invulnerable == false)
        {
            //invulnerable = true;
            health -= enemyDamage;
            Debug.Log("Damage taken");
        }
    }
}
