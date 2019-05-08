using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oneortwo : MonoBehaviour
{
    public void Player_one()
    {
        SceneManager.LoadScene(2);
    }
    public void Player_two()
    {
        SceneManager.LoadScene(2);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
