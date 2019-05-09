using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Medium_Maps : MonoBehaviour
{
    // Start is called before the first frame update
    public void Back()
    {
        SceneManager.LoadScene(2);
    }
    public void Map1()
    {
        SceneManager.LoadScene(9);
    }
    public void Map2()
    {
        SceneManager.LoadScene(10);
    }
}
