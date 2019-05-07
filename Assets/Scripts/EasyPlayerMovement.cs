using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyPlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public int jumpHeight;
    public Vector3 startPos;
    private Rigidbody rb;


	// Start is called before the first frame update
	 void Start()
	 {
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
	 }

    private void FixedUpdate()
	 {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical"); 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        // setting up a ray and a hit for the raycast
        RaycastHit hit;
        Ray jump = new Ray(transform.position, Vector3.down);
        // if space is pressed and the ray has hit at the jumpHeight, jump.
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(jump, out hit, jumpHeight))
        {
            rb.AddForce(0.0f, jumpForce, 0.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("End"))
        {
            StartCoroutine(endGame());
            // go to start for now
            //transform.position = new Vector3(1.5f, 1.1f, 0.5f);
            // write code to go to the next scene

        }
        else if(other.CompareTag("Respawn"))
        {
            respawn();
        }
    }

    public void respawn()
    {
        transform.position = startPos;
        rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
    }

    public IEnumerator endGame()
    {
        yield return new WaitForSeconds(3);

        respawn();

    }
}