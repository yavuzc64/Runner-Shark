using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private int a;
    [SerializeField] private int b;

    private void OnTriggerEnter(Collider other)
    {
        FishManager.instance.ChangeFish(a, b);
        Destroy(gameObject, 0.1f);
    }

}
