using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowDirectional : MonoBehaviour
{
    public Transform cameraTarget;
    public float sSpeed = 10.0f;
    public float zoomSpeed = 1;
    public float minDist;
    public float maxDist;
    public Transform lookTarget;

    void LateUpdate()
    {
        zoomCamera(0);
        Vector3 dPos = cameraTarget.position;
        Vector3 sPos = Vector3.Lerp(transform.position,dPos,sSpeed*Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
        
    }

    
    void zoomCamera(float zoomInput)
    {
        Vector3 newPos = zoomByDistance(zoomInput*zoomSpeed); 
        float distance = Vector3.Distance(lookTarget.localPosition, newPos);
        if (minDist<distance && distance<maxDist)
        {
            cameraTarget.localPosition = newPos;
        }
        if(distance<minDist)
        {
            float moveDist = (distance-minDist);
            if(moveDist>0)
            {
                moveDist *= -1;
            }
            cameraTarget.localPosition = zoomByDistance(moveDist);
        }
        if(distance>maxDist)
        {
            float moveDist = distance - maxDist;
            if(moveDist<0)
            {
                moveDist *= -1;
            }
            cameraTarget.localPosition = zoomByDistance(moveDist);
        }
    }
    
    Vector3 zoomByDistance(float distance)
    {
        return cameraTarget.localPosition + (lookTarget.localPosition - cameraTarget.localPosition).normalized * distance;
    }
}
