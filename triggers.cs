//Trigger script created by Tony Dougal and Chandler Davis.

//Declarations
using UnityEngine;
using System.Collections;

public class triggers : MonoBehaviour
{	
	//Variables
	bool jumpBoostItem = false; 
	bool runSpeedItem = false;

	void Update ()
	{
		//Call the Health script.
		GameObject player = GameObject.Find("player");
		player.GetComponent<Health>();
		
		//Call the Movement script
		player.GetComponent<MovementScript>();
	}

	//When the player enters a trigger.
	void OnTriggerEnter (Collider other)
	{
		//Log that the player has entered a trigger.
		Debug.Log("The player has entered a trigger.");
		
		//If the trigger is shrine.
		if(other.tag == "shrine")
		{
			//Set the damage value for shrine
			double heal = 10f;
			
			//Add the healing to the health.
			Health.health = Health.health + heal;	
		}
		
		//If the trigger is fire.
		if(other.tag == "fire")
		{
			//Set the damage value for fire
			double damage = 10f;
		
			//Subtract the damage from the health.
			Health.health = Health.health - damage;	
		}
		
		//If the trigger is jumpBoost.
		if(other.tag == "jumpBoost")
		{
			//If the player does not have the jumpBoost item.
			if(jumpBoostItem == false)
			{			
				//double the jumpSpeed variable.
				MovementScript.jumpSpeed *= 2;

				//notify script that player has the item.
				jumpBoostItem = true;
			}
				
			//If the player does have the jumpBoost item.
			if(jumpBoostItem == true)
			{
				//Do nothing.
				MovementScript.jumpSpeed *= 1;
			}	
		}	

		//if the trigger is runBoost.
		if(other.tag == "runBoost")
		{
			//If the player does not have the runBoost.
			if(runSpeedItem == false)
			{
				//double the speed variable
				MovementScript.speed *= 1.5f;
				
				//notift script that player has the item.
				runSpeedItem = true;
			}
			
			//If the player does have the runBoostItem.
			if(runSpeedItem == true)
			{
				//Do nothing.
				MovementScript.jumpSpeed*= 1;
			}
		}
	}
	
	//When the player exits a trigger.
	void OnTriggerExit (Collider other)
	{
		//Log that the player has exit a trigger.
		Debug.Log("The player has exited a trigger.");
	}

}
	
