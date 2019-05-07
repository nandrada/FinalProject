using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class LevelOneEaster : MonoBehaviour
{
    public EasyPlayerMovement player;

    public Flowchart flowchart;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        { 
            flowchart.ExecuteBlock("Easter");
        }
        if (flowchart.IsActive())
        {
            StartCoroutine(pause());
        }
    }

    public IEnumerator pause()
    {
        yield return new WaitForSeconds(5);
    }
}
