using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeScript_Mars : MonoBehaviour
{

    int id;
    public GameObject planetMerge;
    public GameObject mergeEffect;
    Rigidbody rig;
    GameObject newPlanet;
    


    void Start()
    {

        id = GetInstanceID();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mars"))
        {
            if (col.gameObject.GetComponent<MeshRenderer>().material.color == GetComponent<MeshRenderer>().material.color)
            {
                if (id < col.gameObject.GetComponent<MergeScript_Mars>().id)
                {
                    return;
                }
                Destroy(col.gameObject);
                Destroy(gameObject);
                ScoreScript.instance.AddPointMars();
                newPlanet = Instantiate(planetMerge, transform.position, transform.rotation);
                newPlanet.GetComponent<NewMove>().enabled = false;
                rig = this.newPlanet.GetComponent<Rigidbody>();
                rig.drag = 10;

                GameObject effect = Instantiate(mergeEffect, newPlanet.transform.position, newPlanet.transform.rotation);
                FindObjectOfType<AudioManager>().Play("MergeSound");
                Destroy(effect, 2f);
            }
        }
    }


}
