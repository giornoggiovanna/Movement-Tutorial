using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{       
    //Public Functions
    public void addDamage(float damage){
        if (damage <= 0) 
            return;
        currentHealth -= damage;

        healthSlider.fillAmount = 1 - currentHealth/fullHealth;

        playerAS.PlayOneShot(playerDamaged);

        damaged = true;

        if(currentHealth <= 0) {
           MakeDead(); 
        }
    }

    public void MakeDead() {
        Instantiate(playerDeathFX, transform.position, Quaternion.identity);
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
    
    //Private Functions
    void Start() {
        currentHealth = fullHealth;        
        playerAS = GetComponent<AudioSource> ();
        healthSlider.fillAmount = 0f;
    }

    void Update(){
        if(damaged){
            damageIndicator.color = flashColor;
        } else{
            damageIndicator.color = Color.Lerp(damageIndicator.color, Color.clear, indicatorSpeed * Time.deltaTime);
        }
        damaged = false;
    }
    //Public Variables
    public string endText = "You have suceeded";
    public Image deathScreen;
    public Image damageIndicator;
    public Image healthSlider;
    public CanvasGroup endCG;
    public Text endgameUIText;
    public float fullHealth;
    public AudioClip playerDamaged;
    public GameObject playerDeathFX;
    //Private Variables
    float currentHealth;
    AudioSource playerAS;
    float indicatorSpeed = 5f;

    bool damaged;

    Color flashColor = new Color (255f, 255f, 255f, 0.5f);
}
