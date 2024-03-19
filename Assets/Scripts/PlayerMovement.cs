using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float minValue;
    [SerializeField] private float maxValue;

    void Update()
    {
        if (!FinishManager.instance.isFinish)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //Debug.Log(transform.position);

            //swipe oynayýs yap


            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Vector3 targetPosition = transform.position + new Vector3(-15, 0, 0);

                targetPosition.x = Mathf.Clamp(targetPosition.x, minValue, maxValue);
                transform.position = targetPosition;
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                Vector3 targetPosition = transform.position + new Vector3(15, 0, 0);

                targetPosition.x = Mathf.Clamp(targetPosition.x, minValue, maxValue);
                transform.position = targetPosition;
            }
        }
        

    }
}
