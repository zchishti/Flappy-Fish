using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour {

    private Score s;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<Seaweed>() != null)
        {
            // Do this only if there is exactly only one Score component
                s = FindObjectOfType<Score>();
                s.addScore();
            
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
