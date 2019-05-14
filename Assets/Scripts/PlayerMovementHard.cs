using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHard : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;
	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
		// Getting horizontal and vertical movement and adding it to a movement vector
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		// Adding movement vector * speed to player rigidbody
		rb.AddForce(movement * speed);
	}
}
