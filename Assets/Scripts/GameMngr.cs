using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMngr : MonoBehaviour
{
    public List<GameObject> liGoSpawn = new List<GameObject>();
    public GameObject firstPlanet;

    GameObject planet;
    Rigidbody rig;
    SphereCollider myCollider;

   
    public Button gravityOn;



    void Start()
    {
       Time.timeScale = 1;
       planet =  Instantiate(firstPlanet, transform.position, transform.rotation);
       rig = this.planet.GetComponent<Rigidbody>();
       myCollider = this.planet.GetComponent<SphereCollider>();
       rig.useGravity = false;
       myCollider.enabled = false;
 
    }

    void Update()
    {
   
    }

   

    public void RandomPlanets()
    {
            int index = Random.Range(0, liGoSpawn.Count);
            planet = Instantiate(liGoSpawn[index], transform.position, transform.rotation);
            rig = this.planet.GetComponent<Rigidbody>();
            rig.useGravity = false;
            OnTriggerDisableScript.onPlayArea = false;
            myCollider = this.planet.GetComponent<SphereCollider>();
            myCollider.enabled = false;
    
    }

    public void GravityActive()
    {
        if (planet != null)
        {
            myCollider.enabled = true;
            rig.useGravity = true;
            OnTriggerDisableScript.onPlayArea = false;
           
            if (OnTriggerDisableScript.onPlayArea == false)
            {
               planet.GetComponent<NewMove>().enabled = false;
               
            }
            



            RandomPlanets();
           
        }
        
    }

  




}
