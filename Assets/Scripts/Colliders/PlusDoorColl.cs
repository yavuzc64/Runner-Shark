using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusDoorColl : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    private void OnTriggerEnter(Collider other)
    {
        FishManager.instance.ChangeFish(-5, 0);
        Destroy(Door, 0.1f);
    }
}
