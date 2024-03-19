using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishColl : MonoBehaviour
{
    [SerializeField] private GameObject Fish;
    private void OnTriggerEnter(Collider other)
    {
        FishManager.instance.ChangeFish(1, 0);
        Destroy(Fish, 0.1f);
    }
}
