using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkColl : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
        FishManager.instance.UpdateScoreText();

        FinishManager.instance.isFinish = true;
    }
}
