using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove : MonoBehaviour
{
    private float speed = 0.01f;
    private Touch touch;


    public static bool spawner = false;
    public static bool isgameOver = false;
 
    void Update()
    {
     
        if (Input.touchCount > 0)
        {
           
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                
               
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z);

            }

            if (touch.phase == TouchPhase.Ended)
            {
                
               
                spawner = true;
                //isgameOver = true;//
            }
        }

   
    }

   





}
