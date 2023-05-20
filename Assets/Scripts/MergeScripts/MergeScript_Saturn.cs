using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeScript_Saturn : MonoBehaviour
{
    int id;
    public GameObject planetMerge;
    public GameObject mergeEffect;
    

    void Start()
    {

        id = GetInstanceID();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Saturn"))
        {
            if (col.gameObject.GetComponent<MeshRenderer>().material.color == GetComponent<MeshRenderer>().material.color)
            {
                if (id < col.gameObject.GetComponent<MergeScript_Saturn>().id)
                {
                    return;
                }
                Destroy(col.gameObject);
                Destroy(gameObject);


       

                ScoreScript.instance.AddPointEarth();
                GameObject newPlanet = Instantiate(planetMerge, transform.position, transform.rotation);
                GameObject effect = Instantiate(mergeEffect, newPlanet.transform.position, newPlanet.transform.rotation);
                FindObjectOfType<AudioManager>().Play("MergeSound");
                Destroy(effect, 2f);
            }
        }
    }
}
