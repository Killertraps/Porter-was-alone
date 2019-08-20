using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{

    public Transform obj;

    float speed = 30;

    Vector2 lastposition;
    Rigidbody2D rb;
    

    private void Start()
    {
        rb = obj.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        //if (//check camera velocity )
        {
            //move camera according
            // when the objects falls then go time scale to .5 and do some camera shake
        }
    }
}
