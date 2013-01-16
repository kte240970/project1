using UnityEngine;
using System.Collections;

public class EnemyAnimation : MonoBehaviour {

	Animation _animation;

 void Start()
 {
 _animation = GetComponentInChildren<Animation>();
		string animationToPlay = "";
 		switch (Random.Range(0, 2))
		{
			 default:
			 case 0:
			 animationToPlay = "walk";
			 break;
			 case 1:
			 animationToPlay = "walk";
			 break;
			
		 }
 		_animation[animationToPlay].wrapMode = WrapMode.Loop;
 		_animation.Play(animationToPlay);
		_animation[animationToPlay].normalizedTime = Random.value;
 }
	
	void Update(){
		float v = Input.GetAxis("Vertical");
		
	}
	
}