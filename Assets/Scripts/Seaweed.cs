using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Seaweed : MonoBehaviour {

    private PauseMenu pauseMenu;
    private bool isActive = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<Fish>() != null)
        {
            SceneManager.LoadScene("FlappyFish");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
