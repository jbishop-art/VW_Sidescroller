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
		
		if (BlueKey == true)
		{
			GameObject.Find("BlueKeyNotice").GetComponent<Renderer>().enabled = true;
			
		}
		else
		{
			GameObject.Find("BlueKeyNotice").GetComponent<Renderer>().enabled = false;
		}

		if (RedKey == true)
		{
			GameObject.Find("MagentaKeyNotice").GetComponent<Renderer>().enabled = true;
		}
		else
		{
			GameObject.Find("MagentaKeyNotice").GetComponent<Renderer>().enabled = false;
		}

		if (GreenKey == true)
		{
			GameObject.Find("GreenKeyNotice").GetComponent<Renderer>().enabled = true;
		}
		else
		{
			GameObject.Find("GreenKeyNotice").GetComponent<Renderer>().enabled = false;
		}
		

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//Detects if player picks up Blue Key.
		if(col.gameObject.tag == "BlueKey")
		{
			BlueKey = true;
			Destroy (col.gameObject);

			GameObject.Find("KeySound").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("KeySound").GetComponent<AudioSource>().enabled = true;
			
		}

		//Opens door if player has a Blue Key.
		if((col.gameObject.tag == "BlueDoor") & (BlueKey == true))
		{
			BlueKey = false;
			Destroy (col.gameObject);

			GameObject.Find("DoorOpenSound").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("DoorOpenSound").GetComponent<AudioSource>().enabled = true;
			
		}

		//Detects if player picks up Red Key.
		if(col.gameObject.tag == "RedKey")
		{
			RedKey = true;
			Destroy (col.gameObject);

			GameObject.Find("KeySound").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("KeySound").GetComponent<AudioSource>().enabled = true;
			
		}

		//Opens door if player has a Red Key.
		if((col.gameObject.tag == "RedDoor") & (RedKey == true))
		{
			RedKey = false;
			Destroy (col.gameObject);

			GameObject.Find("DoorOpenSound").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("DoorOpenSound").GetComponent<AudioSource>().enabled = true;
		}

		//Detects if player picks up Green Key.
		if(col.gameObject.tag == "GreenKey")
		{
			GreenKey = true;
			Destroy (col.gameObject);

			GameObject.Find("KeySound").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("KeySound").GetComponent<AudioSource>().enabled = true;
			
		}

		//Opens door if player has a Green Key.
		if((col.gameObject.tag == "GreenDoor") & (GreenKey == true))
		{
			GreenKey = false;
			Destroy (col.gameObject);

			GameObject.Find("DoorOpenSound").GetComponent<AudioSource>().enabled = false;
			GameObject.Find("DoorOpenSound").GetComponent<AudioSource>().enabled = true;
		}
	}

	
}
