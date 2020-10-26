using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameCleanerScript : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other) {
      if(other.tag == "Player"){
         print("you died");
          other.GetComponent<PlayerHealth>().MakeDead (); 
       }
   }

   public void RestartGame(){
      print("restart");
      SceneManager.LoadScene("Main");
   }

   public void StopGame(){
      print("weakling");
      Application.Quit();
   }

}