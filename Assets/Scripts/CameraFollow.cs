using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform FollowTarget;
    [SerializeField] private Vector3 CamPosition = new Vector3(0, 5, -10);
    private void LateUpdate()
    {
        Vector3 follow = new Vector3(CamPosition.x, CamPosition.y, FollowTarget.position.z + CamPosition.z);
        transform.position = follow;
    }

    
}
