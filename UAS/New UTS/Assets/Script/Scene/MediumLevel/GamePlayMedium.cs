using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayMedium : MonoBehaviour
{
    public void Retry(){
        SceneManager.LoadScene("MediumLevel");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
