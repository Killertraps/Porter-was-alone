using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100f;
    
   

    private void Update()
    {

        transform.Translate(new Vector2(1, 0) * speed * Time.deltaTime * Input.GetAxis("Mouse X"));
        
        
    }
   
}
