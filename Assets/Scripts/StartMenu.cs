using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

    [SerializeField]
    private ClickSound click;
  
    public void StartGame()
    {
        click.Play();
        SceneManager.LoadScene("FlappyFish");
    }

    public void Sound()
    {
        click.Play();
        Debug.Log("Volume Manager Not Implemented");
    }

    public void Quit()
    {
        click.Play();
        Application.Quit();
    }

}
