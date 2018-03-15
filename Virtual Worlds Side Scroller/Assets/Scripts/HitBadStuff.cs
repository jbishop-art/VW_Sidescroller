using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HitBadStuff : MonoBehaviour
{
    private Vector3 spawnPoint;
    private Vector3 playerLoc;
    public ParticleSystem pDPrefab;
    private bool isDead;


    // Use this for initialization
    void Start ()
    {

        isDead = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        playerLoc = GameObject.Find("Player(Clone)").transform.position;

	}

    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(0.25f);
        
        GameObject.Find("Player(Clone)").transform.position = spawnPoint;
        isDead = false;

        yield return new WaitForSeconds(1f);
        GameObject.Find("Main Camera").SendMessage("DeathCount");

    }

    void OnCollisionEnter2D(Collision2D col)
	{

        //Detects if player touches the end point.
        if (col.gameObject.tag == "EndPoint")
        {
			GameObject.Find("Main Camera").SendMessage("Finnish");
            Debug.Log("Sent Message to camera timer");
        }

        
        //Detects if player touches a spawn point.
        if (col.gameObject.tag == "CheckPoint")
        {
            spawnPoint = col.gameObject.transform.position;

            Destroy(col.gameObject);

            GameObject.Find("CheckPointSound").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("CheckPointSound").GetComponent<AudioSource>().enabled = true;
        }

        
		//Detects if player touches BadStuff.
		if(col.gameObject.tag == "BadStuff" && ! isDead)
		{

            Instantiate(pDPrefab, playerLoc, Quaternion.identity);

            GameObject.Find("DeathSound").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("DeathSound").GetComponent<AudioSource>().enabled = true;


            isDead = true;
            StartCoroutine("Wait");

            //GameObject.Find("Player(Clone)").transform.position = spawnPoint;

        }


        
		
	}

}
