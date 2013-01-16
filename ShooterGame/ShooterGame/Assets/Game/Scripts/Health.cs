using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	[SerializeField]
 int _maximumHealth = 100;
 int _currentHealth = 100;
	override public string ToString()
		 {
		 return _currentHealth + " / " + _maximumHealth;
		 }
 void Start()
 {
 _currentHealth = _maximumHealth;
 }
	public void Damage(int damageValue)
 {
 _currentHealth -= damageValue;
		if (_currentHealth <= 0)
			 {
			 Destroy(gameObject);
			
			
			Destroy(GetComponent<PlayerMovement>());

 Destroy(GetComponent<EnemyMovement>());
 Destroy(GetComponent<CharacterController>());
			 }
 }
}
