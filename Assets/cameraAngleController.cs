using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAngleController : MonoBehaviour
{

    public float rotSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotateCamera = Vector3.zero;
        rotateCamera.x = Input.GetAxis("Mouse Y");
        Debug.Log(rotateCamera);
        transform.localEulerAngles -= rotateCamera*rotSpeed;
    }
}
