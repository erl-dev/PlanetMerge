using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeScript_Jupiter : MonoBehaviour
{
    int id;
    public GameObject mergeEffect;
    

    void Start()
    {

        id = GetInstanceID();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Jupiter"))
        {
            if (col.gameObject.GetComponent<MeshRenderer>().material.color == GetComponent<MeshRenderer>().material.color)
            {
                if (id < col.gameObject.GetComponent<MergeScript_Jupiter>().id)
                {
                    return;
                }
                Destroy(col.gameObject);
                Destroy(gameObject);
                ScoreScript.instance.AddPointJupiter();
                GameObject effect = Instantiate(mergeEffect, transform.position, transform.rotation);
                FindObjectOfType<AudioManager>().Play("MergeSound");
                Destroy(effect, 2f);
            }
        }
    }
}
