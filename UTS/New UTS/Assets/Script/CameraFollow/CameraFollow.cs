using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour
{
    private Func<Vector3> GetCameraFunc;

    public void Setup(Func<Vector3> GetCameraFunc){
        this.GetCameraFunc = GetCameraFunc;
    }

    void Update()
    {
        Vector3 camFollowPosition = GetCameraFunc();
        camFollowPosition.z = transform.position.z;

        Vector3 camMoveDir = (camFollowPosition - transform.position).normalized;
        float distance = Vector3.Distance(camFollowPosition, transform.position);
        float camMoveSpeed = 4.3f;

        if(distance > 0){
            Vector3 newCamPosition = transform.position + camMoveDir * distance * camMoveSpeed * Time.deltaTime;
            float distanceAfterMove = Vector3.Distance(newCamPosition, camFollowPosition);
            
            if(distanceAfterMove > distance){
                newCamPosition = camFollowPosition;
            }

            transform.position = newCamPosition;
        }

        
    }
}
