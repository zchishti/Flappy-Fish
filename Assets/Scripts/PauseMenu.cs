using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseUI;

    [SerializeField]
    private bool isActive = false;

    [SerializeField]
    private bool ActiveOnAwake = false;

    
    private void Awake()
    {
        if (ActiveOnAwake)
        {
            SetPauseMenu(true);
        }
        else
        {
            SetPauseMenu(false);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Set Pause Menu");
            SetPauseMenu(!isActive);
        }
        
	}

    public void SetPauseMenu(bool state)
    {
        pauseUI.SetActive(state);
        isActive = state;

        if (state)
            Time.timeScale = 0;
        else
            Time.timeScale = 1f;

    }

    public void Restart()
    {
        SceneManager.LoadScene("FlappyFish");
    }

    public void Volume()
    {
        Debug.Log("Volume Controls not Implemented.");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
