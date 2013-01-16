using UnityEngine;
using System.Collections;

public class Player_real_move : MonoBehaviour {

	 public float JumpSpeed=100;
	//=================================//
    public float speedLeftRight = 0.0F;
	public float speedForvard = 0.0F;
	public float speedUpDown = 0.0F;
	 public float speed = 60.0f;
	  public float airModifier = 0.2f;
	  public float jumpForce = 10.0f;
	
	  private Vector3 moveDirection = Vector3.zero;
	
	void OnCollisionEnter(Collision collision){
		Debug.Log("Collision!");
		 foreach (ContactPoint contact in collision.contacts) 
		{
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
		
		for(int i=1;i<=4;i++)
		{
			if(collision.gameObject.name=="Bonus"+i)
				   {
				    Debug.Log("Collision Bonus"+i);
					 Destroy(GameObject.FindWithTag("Bonus"+i));
				   }
			
		}
		if(collision.gameObject.name=="Plane")
				   {
			 Debug.Log("Collision Plane");
					}
		
	}
	 Vector3 horMovement;
	 Vector3 forwardMovement;
    void Update() {
     
		
		//=================================//
		//Проверка на касание земли
		 bool grounded;
	     //is the user pressing left or right (or "a & "d") on the keyboard?
//        Vector3 horMovement = Input.GetAxis("Horizontal") * transform.right * Time.deltaTime * speed;
//        //is the user pressing up or down (or "w" & "s") on the keyboard?
//      Vector3 forwardMovement = Input.GetAxis("Vertical") * transform.forward * Time.deltaTime * speed;
//		
		
        
      
		
		
    	//are we grounded?
        if (Physics.Raycast(transform.position, -transform.up, 2)) {
            grounded = true;
        } else {
            horMovement *= airModifier;
            forwardMovement *= airModifier;
            grounded = false;
			
        }
 	//=================================//
		//jump if the user pressing the space key AND our character is grounded
        if (Input.GetKeyUp("space") && grounded)
			// if (Input.GetKeyUp("space") )
        {
			Debug.Log("Pressed2");
           rigidbody.AddRelativeForce(transform.up * jumpForce, ForceMode.Impulse);
  		//  rigidbody.AddForce(Vector3.up *jumpForce);
			
        }
		
		
		
		
		
		
		
		
		
		
		
		
		if(Input.GetKey(KeyCode.W))
		{
			
			speedForvard+=0.3f;
		
		}
			if(Input.GetKey(KeyCode.S))
		{
			
			speedForvard-=0.3f;
	
		}
		
		if(Input.GetKey(KeyCode.A))
		{
			speedLeftRight=50;
			transform.Rotate(Vector3.up,-speedLeftRight*Time.deltaTime, Space.World);
		}
		
			if(Input.GetKey(KeyCode.D))
		{
			
			speedLeftRight=50;
			transform.Rotate(Vector3.up,speedLeftRight*Time.deltaTime, Space.World);
		}
//		transform.rigidbody.velocity =  transform.forward*speedForvard*Time.deltaTime;
		transform.position += transform.forward*speedForvard*Time.deltaTime;

		
          
}}

