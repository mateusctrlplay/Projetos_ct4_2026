using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("SampleScene");
    }
        public void Credits(){
        SceneManager.LoadScene("Credits");
    }
        public void Quit(){
        Application.Quit();
        
    }
        public void BackToMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}

// i am the gummy bear, i am the gummy bear, i am the gummy bear, i am the gummy bear i am the gummy bear, i am the gummy bear, i am the gummy bear, i am the gummy bear i am the gummy bear, i am the gummy bear, i am the gummy bear, i am the gummy bear