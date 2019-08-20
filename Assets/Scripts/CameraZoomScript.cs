using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomScript : MonoBehaviour
{
    Camera mainCamera;
    public GameObject obj;

    void Start()
    {
        mainCamera = Camera.main;
        mainCamera.enabled = true;
        
    }

    void Update()
    {
        if (obj && mainCamera.orthographicSize < 66f)
        {

            if (mainCamera.fieldOfView <= 125)
                mainCamera.fieldOfView += 2;
            if (mainCamera.orthographicSize <= 20)
                mainCamera.orthographicSize += 0.5f;

        }
        else 
        {
            if (mainCamera.orthographicSize > 55)
            {
                if (mainCamera.fieldOfView > 2)
                    mainCamera.fieldOfView -= 1;
                if (mainCamera.orthographicSize >= 1)
                    mainCamera.orthographicSize -= 0.5f;
            }
        }
    }
}
