using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideReturn : MonoBehaviour
{
   [SerializeField]
    private List<GameObject> list1;

    float last_time;
    int i = 0;

    private void Start()
    {
        last_time = Time.time;

    }

    private void Update()
    {
        if (Time.time - last_time > 5 && list1[i]!=null)
        {
            list1[i].SetActive(true);
          
            ++i;
            last_time = Time.time;
        }

    }


}
