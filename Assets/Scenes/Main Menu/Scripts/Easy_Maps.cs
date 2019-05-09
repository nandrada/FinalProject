using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Easy_Maps : MonoBehaviour
{
    // Start is called before the first frame update
    public void Back()
    {
        SceneManager.LoadScene(2);
    }
    public void Map1()
    {
        SceneManager.LoadScene(6);
    }
    public void Map2()
    {
        SceneManager.LoadScene(7);
    }
    public void Map3()
    {
        SceneManager.LoadScene(8);
    }
}
