using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public GameObject hitEffect;
    public int damage = 10;
   void Start()
    {
        Destroy(gameObject, 3f);
    }
       
    void OnTriggerEnter2D (Collider2D hitInfo){
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        BBreak BBreak = hitInfo.GetComponent<BBreak>();
        GGreak GGreak = hitInfo.GetComponent<GGreak>();
         if (enemy != null){
             enemy.TakeDamage(damage);
         }
         Destroy(gameObject);
         if (BBreak != null){
             BBreak.TakeDamage(damage);
         }
         Destroy(gameObject);
         if (GGreak != null){
             GGreak.TakeDamage(damage);
         }
         Destroy(gameObject);

     }

 void OnCollisionEnter2D(Collision2D collision){
         //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
         //Destroy(effect, 5f);
         
         Destroy(gameObject);


     }
}