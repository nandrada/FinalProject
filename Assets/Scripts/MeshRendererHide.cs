using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererHide : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			this.GetComponent<MeshRenderer>().enabled = false;
		}
	}
}
