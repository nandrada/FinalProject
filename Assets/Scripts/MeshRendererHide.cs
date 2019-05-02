using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererHide : MonoBehaviour
{

	private void OnCollisionEnter(Collision other)
	{
		gameObject.GetComponent<Renderer>().enabled = false;
	}
}
