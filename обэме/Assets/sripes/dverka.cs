using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dverka : MonoBehaviour
{
    public GameObject dver;
void OnTriggerEnter2D (Collider2D hitInfo){
       Bullet bullet = hitInfo.GetComponent<Bullet>();
       if (bullet != null){
             dver.SetActive(false);
       }
   }
}