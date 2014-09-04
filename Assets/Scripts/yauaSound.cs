using UnityEngine;
using System.Collections;

public class yauaSound : MonoBehaviour {

	
	bool letsRock = false;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( letsRock == true )
		{
			audio.Play();
			letsRock = false;
		}
	}
	
	public void RockIt2()
	{
		letsRock = true;
	}
}
