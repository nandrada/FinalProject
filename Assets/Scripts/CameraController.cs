	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject player;
	public Vector3 offset;

	// Start is called before the first frame update
	void Start()
	{
		// Camera offset
		offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		// Camera will follow players position + offset
		transform.position = player.transform.position + offset;
	}
}
