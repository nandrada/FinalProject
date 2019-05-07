using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript2 : MonoBehaviour
{
	public Text winText;

	void Start()
	{
		winText.text = "";
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("YOU WIN!!");
			winText.text = "Level Complete!";
		}
	}
}
