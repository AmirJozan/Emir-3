using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    public void Sahne1Button()
    {
        SceneManager.LoadScene(1);
    }
    public void Sahne2Button()
    {
        SceneManager.LoadScene(2);
    }
    public void Sahne3Button()
    {
        SceneManager.LoadScene(3);
    }
    public void Sahne4Button()
    {
        SceneManager.LoadScene(4);
    }
    public void Sahne5Button()
    {
        SceneManager.LoadScene(5);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
