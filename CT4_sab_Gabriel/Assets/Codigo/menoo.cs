using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menoo : MonoBehaviour
{
    public void startGame(){
        SceneManager.LoadScene("SampleScene");
    }
    public void  Reconhecimento(){
        SceneManager.LoadScene("Credits");
    }
    public void  Quit(){
        Application.Quit();
    }
    public void Sair(){
        SceneManager.LoadScene("MainMenu");
    }
}



