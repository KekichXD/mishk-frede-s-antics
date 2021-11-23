using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mech2 : MonoBehaviour
{
    public GameObject sword;
    void Start(){
       sword.SetActive(false);
    }

   void OnTriggerEnter2D (Collider2D col){
       sword.SetActive(true);
       gameObject.SetActive(false);
    }
    
}
