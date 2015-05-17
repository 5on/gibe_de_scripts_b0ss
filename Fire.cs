//Fire script created by Tony Dougal and Chandler Davis

//Declarations
using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{
	//When the player enters the fire.
	void OnTriggerEnter (Collider other)
	{
		//If the trigger is fire
		if(other.tag == "fire")
		{
			//Set the damage value for fire
			double damage = 10f;

			//Call the health value from the Health script.
			GameObject player = GameObject.Find("player");
			player.GetComponent<Health>();
		
			//Subtract the damage from the health.
			Health.health = Health.health - damage;	
		}
	}
}
