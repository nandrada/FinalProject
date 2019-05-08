using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;
<<<<<<< HEAD:Assets/PlayerMovement.cs
    public Vector3 startingPosition;
=======
	public float RotateSpeed = 30.0f;
>>>>>>> fdcace5f3023d7469dc609e0cb50c3d1f68f1fd6:Assets/Scripts/PlayerMovement.cs

    // Create a temporary reference to the current scene.
    Scene currentScene = SceneManager.GetActiveScene();

    // Retrieve the name of this scene.
    
// Start is called before the first frame update
void Start()
	{
		rb = GetComponent<Rigidbody>();

        string sceneName = currentScene.name;

        if (sceneName == "Medium Level 1")
        {
           startingPosition = new Vector3(76.5f, 84.01f, 0);
        }
        else if (sceneName == "Medium Level 2")
        {
            startingPosition = new Vector3(0f, 0f, 0f);
        }

        //// Retrieve the index of the scene in the project's build settings.
        //int buildIndex = currentScene.buildIndex;

        //// Check the scene name as a conditional.
        //switch (buildIndex)
        //{
        //    case 0:
        //        // Do something...
        //        break;
        //    case 1:
        //        // Do something...
        //        break;
        //}

    }

    private void FixedUpdate()
	{
		// Getting horizontal and vertical movement and adding it to a movement vector
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		// Adding movement vector * speed to player rigidbody
		rb.AddForce(movement * speed);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "untouchable")
        {
            transform.position = startingPosition;
            rb.velocity = Vector3.zero;
        }
    }
}