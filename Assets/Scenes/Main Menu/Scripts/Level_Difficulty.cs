using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Difficulty : MonoBehaviour
{
    // Start is called before the first frame update
    public void Easy()
    {
        SceneManager.LoadScene(3);
    }
    public void Medium()
    {
        SceneManager.LoadScene(4);
    }
    public void Hard()
    {
        SceneManager.LoadScene(5);
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}
