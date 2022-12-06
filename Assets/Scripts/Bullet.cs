using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public bool isMelee;
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "bulletCase")
        {
            Destroy(gameObject, 10.0f);
        }
        if(collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject, 3.0f);
        }
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

}
