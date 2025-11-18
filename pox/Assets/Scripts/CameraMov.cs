using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    private float smothTime = 0.2f;
    [SerializeField]
    private float distanceAhead = 2f;
    private Vector3 velocity = Vector3.zero;
    private void LateUpdate()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        Vector3 targetPos = target.position + new Vector3(direction * distanceAhead, 0, -10);

        //     Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
           transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smothTime);
    }
}
