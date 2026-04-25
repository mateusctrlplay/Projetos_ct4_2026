using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meumenuinsertexto : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Quit()
        Application.Quit();
    }
    public void credtis()
    {
        SceneManager.LoadScene("credits");
    }
    public void credtis()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
