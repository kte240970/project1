using UnityEngine;
using System.Collections;

public class LookY : MonoBehaviour {

	[SerializeField]
 float _sensitivity = 5.0f;

 float _mouseY = 0.0f;

 void Update()
 {
 _mouseY = -Input.GetAxis("Mouse Y");

 Vector3 rot = transform.localEulerAngles;
 rot.x += _mouseY * _sensitivity;
 transform.localEulerAngles = rot;
 }
}
