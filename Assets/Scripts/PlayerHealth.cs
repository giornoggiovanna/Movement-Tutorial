using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{

    public void MakeDead() {
        endText = "get absolutely nae-nae'd";
        EndGame ();
        deathScreen.color = Color.white;
        Destroy(gameObject);
    }

    public void EndGame(){
        endgameUIText.text = endText;
        endCG.alpha = 1;
        print (endText);
    }
    
    public string endText = "You have suceeded";
    public Image deathScreen;
    public CanvasGroup endCG;
    public Text endgameUIText;
}
