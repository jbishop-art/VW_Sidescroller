using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour 
{

	public float ZPos;
	private float XPos;
	private float YPos;

	public GameObject jumpSoundPrefab;

	// Use this for initialization
	void Start () 
	{

		
	}
	
	// Update is called once per frame
	void Update () 
	{

		XPos = GameObject.Find("Player(Clone)").transform.position.x;
		YPos = GameObject.Find("Player(Clone)").transform.position.y;

		transform.position = new Vector3(XPos, YPos, ZPos);

		if(Input.GetKeyDown(KeyCode.Space)) 
		{
			Debug.Log("JumpSound!!");
			Instantiate(jumpSoundPrefab, transform.position, Quaternion.identity);
		}
			 

	}
}
