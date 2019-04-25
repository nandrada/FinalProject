using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyPlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
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

        if(Input.GetKeyDown(KeyCode.Space) && rb.transform.position.y <= 1.5)
        {
            rb.AddForce(0.0f, jumpForce, 0.0f);
        }
    }
}