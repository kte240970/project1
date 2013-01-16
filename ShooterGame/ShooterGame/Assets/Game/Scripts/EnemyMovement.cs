using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	CharacterController _controller;
	Transform _player;
	
	[SerializeField]
	 float _moveSpeed = 6.5f;
	
	//Р_С_Р°Р_РёС'Р°С┼РёС_
	[SerializeField]
 	float _gravity = 2.0f;
	float _yVelocity = 0.0f;
	
	
	
	// Use this for initialization
	void Start () {
	 GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
	 _player = playerGameObject.transform;
	_controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	 Vector3 direction = _player.position - transform.position;
		direction.Normalize();
		Vector3 velocity = direction * _moveSpeed;
		//================================//
		//Р_С_Р°Р_РёС'Р°С┼РёС_
		if (!_controller.isGrounded)
		 {
		 _yVelocity -= _gravity;
		 }
		//================================//
 		velocity.y = _yVelocity;
		direction.y = 0;//

		//направл на игрока
		transform.rotation = Quaternion.LookRotation(direction);


		//if(move==true)
			_controller.Move(velocity * Time.deltaTime/1);
	}
	bool move=false;
	
	
	
	void OnTriggerEnter(Collider myTrigger) 
	{
  
	}
}
