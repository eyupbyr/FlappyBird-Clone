using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    [SerializeField] private float jumpForce = 100f;
    private Rigidbody2D rgbd;

    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rgbd.velocity = Vector2.up * jumpForce;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.parent.tag == "Pipe")
        {
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
}
