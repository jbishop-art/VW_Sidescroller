using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyTracker : MonoBehaviour 
{

	bool BlueKey;
	bool RedKey;
	bool GreenKey;


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
		//Detects if player picks up Blue Key.
		if(col.gameObject.tag == "BlueKey")
		{
			BlueKey = true;
			Destroy (col.gameObject);
			
		}

		//Opens door if player has a Blue Key.
		if((col.gameObject.tag == "BlueDoor") & (BlueKey == true))
		{
			BlueKey = false;
			Destroy (col.gameObject);
		}

		//Detects if player picks up Red Key.
		if(col.gameObject.tag == "RedKey")
		{
			RedKey = true;
			Destroy (col.gameObject);
			
		}

		//Opens door if player has a Red Key.
		if((col.gameObject.tag == "RedDoor") & (RedKey == true))
		{
			RedKey = false;
			Destroy (col.gameObject);
		}

		//Detects if player picks up Green Key.
		if(col.gameObject.tag == "GreenKey")
		{
			GreenKey = true;
			Destroy (col.gameObject);
			
		}

		//Opens door if player has a Green Key.
		if((col.gameObject.tag == "GreenDoor") & (GreenKey == true))
		{
			GreenKey = false;
			Destroy (col.gameObject);
		}
	}

	
}
