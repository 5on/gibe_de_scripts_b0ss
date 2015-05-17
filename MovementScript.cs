//Movement script example given by Unity for C#
//I edited this to suit our project - Tony Dougal

//Declarations.
using UnityEngine;
using System.Collections;

//Main functions.
public class MovementScript : MonoBehaviour 
{
	//Variables.
    public static float speed = 6.0F; //Movement speed.
	public static float jumpSpeed = 8.0F; //Jump speed and height.
    public static float gravity = 20.0F; //Deceleration and fall speed.
    private Vector3 moveDirection = Vector3.zero;//Variable for key pressing.
	
	//Update on every frame.
    void Update() 
	{
		//Call the characterController script.
        CharacterController controller = GetComponent<CharacterController>();
		
		//If the player is not falling or jumping
        if (controller.isGrounded) 
		{
			//The inputed key press
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			
			//Move according to the inputed key press
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
			
			//Jumping
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;            
        }
		
		//Jumping while moving.
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}