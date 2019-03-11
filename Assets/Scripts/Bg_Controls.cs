using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg_Controls : MonoBehaviour {

    [SerializeField]
    private float xPos = -19.67f;

    [SerializeField]
    private float amountToMove = 19.67f * 3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.x <= xPos)
        {
            this.gameObject.transform.position = new Vector3(amountToMove,this.transform.position.y,this.transform.position.z);
        }
	}
}
