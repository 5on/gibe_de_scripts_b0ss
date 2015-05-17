//Shrine script created by Tony Dougal and Chandler Davis

//Declarations
using UnityEngine;
using System.Collections;

public class Shrine : MonoBehaviour
{
	//When the player enters the shrine.
	void OnTriggerEnter (Collider other)
	{		
		//If the trigger is shrine
		if(other.tag == "shrine")
		{
			//Set the damage value for shrine
			double heal = 10f;

			//Call the health value from the Health script.
			GameObject player = GameObject.Find("player");
			player.GetComponent<Health>();
			
			//Add the healing to the health.
			Health.health = Health.health + heal;	
		}
	}	
}
