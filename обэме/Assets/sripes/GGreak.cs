using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGreak : MonoBehaviour
{
    public int health = 10;
    public GameObject teckst;
        
          void Start(){
       teckst.SetActive(false);
    }
    
    
    public void TakeDamage(int damage){
        health -= damage;

        if (health <= 0) Die();
    }

    void Die(){
        teckst.SetActive(true);
    }
}