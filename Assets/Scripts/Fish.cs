using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour {

    [SerializeField]
    private float jumpForce = 300f;

    [SerializeField]
    private float maxTransform = 7.2f;

    [SerializeField]
    private float minTransform = -4f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }

        if (transform.position.y >= maxTransform || transform.position.y <= minTransform)
        {
            SceneManager.LoadScene("FlappyFish");
        }
	}
}
