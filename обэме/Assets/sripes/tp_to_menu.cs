using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp_to_menu : MonoBehaviour
{
   public void ToMenu (){
       SceneManager.LoadScene ("Main menu");
   }
   public void vozrozhdalka (){
       SceneManager.LoadScene ("SampleScene");
       
   }
}
