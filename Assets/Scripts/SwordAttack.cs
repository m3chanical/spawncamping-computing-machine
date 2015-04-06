using UnityEngine;
using System.Collections;

public class SwordAttack : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other){
		if(other.tag == "Enemy"){
			print("Ouch! You hit me.");
			// Summon up Enemy Damage, subtract enemy health
			// Summon up Enemy Knockback script. 
			// Possibly craft up enemy health bar? 
		}
	}
}
