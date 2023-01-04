using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 3f;
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
        if(collision.gameObject.tag == "Enemy" && invulnerable == false)
        {
            //invulnerable = true;
            health -= enemyDamage;
            Debug.Log("Damage taken");
        }
    }
}
