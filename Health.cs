//Health Script created by Tony Dougal and Chandler Davis

//Declarations
using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
	//Variable that stores the health.
	public static double health = 100f;
	public static double maxHealth = 100f;

	// Update is called once per frame
	void Update () 
	{
		//If the player is alive.
		if (health >= 1)
			//Display total health in the Debug Log.
			Debug.Log("Player has a total health of: " + health + "/" + maxHealth);
		
		//If the player runs out of health.
		if (health <= 0)
			Debug.Log("The player is dead.");
	}
}