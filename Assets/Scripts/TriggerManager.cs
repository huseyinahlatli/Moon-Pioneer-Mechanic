using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    CubeCollector cubeCollector;
    bool isAlreadyCollected = false;

    private void OnTriggerEnter(Collider other)
    {
        if(isAlreadyCollected) 
            return;

        if(other.CompareTag("Player"))
        {
            if(other.TryGetComponent(out cubeCollector))
            { 
                cubeCollector.AddNewItem(this.transform);
                isAlreadyCollected = true;
            }
        }
    }
}
