using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GamePlayEasy : MonoBehaviour
{
    public void Retry(){
        SceneManager.LoadScene("EasyLevel");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
