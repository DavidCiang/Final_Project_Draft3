using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class dialogtrigger : MonoBehaviour
{
    public Flowchart flowchart;
    public string blockName;
    private bool hasTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            flowchart.ExecuteBlock(blockName);
            hasTriggered = true;
        }
    }
}
