using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musuh_Standart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            CoinsCounter.coinAmount += 3;
            Destroy(gameObject);
        }
    }
}
