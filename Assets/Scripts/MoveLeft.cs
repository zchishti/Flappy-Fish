using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    [SerializeField]
    private float moveSpeed = 2f;

    [SerializeField]
    private float randomOffset = 1.3f;
	
	// Update is called once per frame
	void Update () {
        
        transform.position += Time.deltaTime * moveSpeed * Vector3.left;

        if(transform.position.x <= -15)
        {
            float randomHeight = Random.Range(-randomOffset,randomOffset);
            transform.position = new Vector3(15, transform.position.y + randomHeight, transform.position.z);
        }
	}
}
