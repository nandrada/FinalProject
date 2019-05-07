using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
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
			WaitForSecondsRealtime(10);
		}
	}

	private void WaitForSecondsRealtime(int v)
	{
		SceneManager.LoadScene("Hard Level 2");
	}
}
