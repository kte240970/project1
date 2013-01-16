using UnityEngine;
using System.Collections;

public class LookX : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	[SerializeField]
	float _sensitivity = 5.0f;
 float _mouseX = 0.0f;

 void Update()
 {
 _mouseX = Input.GetAxis("Mouse X");
		Vector3 rot = transform.localEulerAngles;
 	rot.y += _mouseX * _sensitivity;
 	transform.localEulerAngles = rot;
 }
}
