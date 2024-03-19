using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoldDoorColl : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    
    private void OnTriggerEnter(Collider other)
    {
        FishManager.instance.ChangeFish(2, 1);
        Destroy(gameObject, 0.1f);
    }
}
