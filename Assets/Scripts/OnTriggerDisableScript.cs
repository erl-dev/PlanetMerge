using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDisableScript : MonoBehaviour
{
    public static bool onPlayArea = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Mercury")
        {
            onPlayArea = true;
            Debug.Log("Collided");
        }

        if (collision.gameObject.tag == "Mars")
        {
            onPlayArea = true;
            Debug.Log("Collided");
        }

        if (collision.gameObject.tag == "Venus")
        {
            onPlayArea = true;
            Debug.Log("Collided");
        }

        if (collision.gameObject.tag == "Earth")
        {
            onPlayArea = true;
            Debug.Log("Collided");
        }

        if (collision.gameObject.tag == "Neptune")
        {
            onPlayArea = true;
            Debug.Log("Collided");
        }

        if (collision.gameObject.tag == "Uranus")
        {
            onPlayArea = true;
            Debug.Log("Collided");
        }

        if (collision.gameObject.tag == "Saturn")
        {
            onPlayArea = true;
            Debug.Log("Collided");
        }

        if (collision.gameObject.tag == "Jupiter")
        {
            onPlayArea = true;
            Debug.Log("Collided");
        }
    }
}
