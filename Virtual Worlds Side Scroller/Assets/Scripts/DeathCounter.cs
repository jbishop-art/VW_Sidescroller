using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCounter : MonoBehaviour
{

    public Text deathCounterText;
    private int deathNumber = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        deathCounterText.text = "Deaths: " + deathNumber;

    }

    public void DeathCount()
    {
        deathNumber ++;

        
    }
}
