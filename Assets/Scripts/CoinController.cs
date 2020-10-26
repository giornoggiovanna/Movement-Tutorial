using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    public GameObject reward;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Instantiate(reward,transform.position,Quaternion.identity);
            other.gameObject.GetComponent<PlayerInventory> ().AddCoins ();
            Destroy (gameObject.transform.root.gameObject);
        }
    }

}
