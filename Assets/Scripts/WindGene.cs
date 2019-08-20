using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindGene : MonoBehaviour
{
    public GameObject wind_prefab, lwind,rwind;
    private GameObject current_wind,windsprite;
    AreaEffector2D obj;
    float Last_wind_time, Time_interval,spawn_time;
    float magnitude_of_force=3f;

    bool right;
    public float start_time=30f;

    void Start()
    {
        obj = wind_prefab.GetComponent<AreaEffector2D>();
        Last_wind_time = Time.time;
        Time_interval = 7f;
        right = false;
    }

    
    void Update()
    {
        if (Time.time - start_time > Time_interval)
        {
            if (Time.time - Last_wind_time > Time_interval)
            {
                current_wind = Instantiate(wind_prefab, Vector2.zero, Quaternion.identity);
                Debug.Log("Wind");
                Last_wind_time = Time.time;
                obj.forceMagnitude = magnitude_of_force;
                spawn_time = Time.time;
                if (right)
                {
                    obj.forceAngle = 180;
                    right = false;
                    Debug.Log("left");
                }
                else
                {
                    obj.forceAngle = 0;
                    right = true;
                    Debug.Log("Right");
                }

                if (obj.forceAngle == 0)
                {
                    windsprite = Instantiate(rwind, rwind.transform.position, Quaternion.identity);
                }
                else if(obj.forceAngle == 180)
                {
                    windsprite = Instantiate(lwind, lwind.transform.position, Quaternion.identity);
                }
                
                 

                

            }
        }
        if (Time.time - spawn_time > 3f && current_wind != null)
        {
            Destroy(current_wind);
            Destroy(windsprite);
            obj.forceMagnitude = magnitude_of_force + 6;
            Debug.Log("Destroyed");
        }
    }

    
}
