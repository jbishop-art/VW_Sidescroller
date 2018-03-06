using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HitBadStuff : MonoBehaviour
{
    private Vector3 spawnPoint;


    // Use this for initialization
    void Start ()
    {

                
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
        //Detects if player touches a spawn point.
        if (col.gameObject.tag == "CheckPoint")
        {
            spawnPoint = col.gameObject.transform.position;

            Destroy(col.gameObject);
        }

        
		//Detects if player touches BadStuff.
		if(col.gameObject.tag == "BadStuff")
		{

            GameObject.Find("Player(Clone)").transform.position = spawnPoint;

        }


        
		
	}

}
