using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	CharacterController _controller;
	[SerializeField]
 	float _moveSpeed = 10.0f;
	
	[SerializeField]
 float _jumpSpeed = 20.0f;

 [SerializeField]
 float _gravity = 1.0f;
	float	mouseX;
 float _yVelocity = 0.0f;
	// Use this for initialization
	void Start () {
	_controller=GetComponent<CharacterController>();
//		GetComponent<Health>().Damage(999);
	}
	
	// Update is called once per frame
	void Update () {
	Vector3 direction=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
		Vector3 velocity = direction * _moveSpeed;
		if (_controller.isGrounded)
			 {
					 if (Input.GetButtonDown("Jump"))
					 {
					 _yVelocity = _jumpSpeed;
					 }
			 }
			 else
			 {
			 		_yVelocity -= _gravity;
			 }
		
		
		
		
			 velocity.y = _yVelocity;
		//===================================//Поворот
			velocity = transform.TransformDirection(velocity);///////////
		//===================================//
		_controller.Move(velocity*Time.deltaTime);
	}
}
