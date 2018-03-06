using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HitBadStuff : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//Detects if player touches BadStuff.
		if(col.gameObject.tag == "BadStuff")
		{
			
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			
		}

		
	}

}
