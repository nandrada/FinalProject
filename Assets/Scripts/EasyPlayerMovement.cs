using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyPlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public int jumpHeight;
    private Rigidbody rb;

	// Start is called before the first frame update
	 void Start()
	 {
        rb = GetComponent<Rigidbody>();
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
            transform.position = new Vector3(1.5f, 1.1f, 0.5f);
        }else if(other.CompareTag("Easter"))
        {
            // go to start for now 
            transform.position = new Vector3(1.5f, 1.1f, 0.5f);
            // write code to pause the scene, 
            // display that the easter egg has been found, 
            // display the creator of the level for this level
            // think of more options to do for an easter egg ex. colors, ball attributes, etc...
        }
    }

    public IEnumerator endGame()
    {
        yield return new WaitForSeconds(3);

        transform.position = new Vector3(1.5f, 1.1f, 0.5f);

    }

    public IEnumerator easterEgg()
    {
        // display that the easter egg has been found,
        // display the creator of the level for this level

        // wait for 5 seconds
        yield return new WaitForSeconds(5);

        // think of more options to do for an easter egg ex. colors, ball attributes, etc...
        
        // go to start  
        transform.position = new Vector3(1.5f, 1.1f, 0.5f);
    }
}