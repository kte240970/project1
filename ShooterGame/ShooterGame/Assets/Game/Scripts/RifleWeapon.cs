using UnityEngine;
using System.Collections;

public class RifleWeapon : MonoBehaviour {
	[SerializeField]
 int _damageDealt = 50;
	// Use this for initialization
	void Start () {
	//Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
		 {
		 Screen.lockCursor = false;
		 }
		if (Input.GetButtonDown("Fire1"))
		{		Screen.lockCursor = true;

			 Ray mouseRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
			 RaycastHit hitInfo;

		 if (Physics.Raycast(mouseRay, out hitInfo))
		 {
		 		Debug.Log(hitInfo.transform.name);
				Health enemyHealth = hitInfo.transform.GetComponent<Health>();
				 if (enemyHealth != null)
				 {
				 enemyHealth.Damage(_damageDealt);
				 }
		 }
		}
	}} 