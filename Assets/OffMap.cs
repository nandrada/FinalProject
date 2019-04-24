using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OffMap : MonoBehaviour
{
	private void Start()
	{
		Debug.Log("started the offMap Script");
	}
	private void OnCollisionEnter(Collision collision)
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Debug.Log("Player has entered area of no return");
	}
}
