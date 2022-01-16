using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject GameOverPanel;

    void Start(){
        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.tag == "Musuh Bebuyutan"){
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
