using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Enemy"){
			Destroy (gameObject);
			Destroy(col.gameObject);
		}
		
		if(col.gameObject.tag == "Fuel"){
			Destroy (gameObject);
			Destroy(col.gameObject);
		}
		
		if(col.gameObject.tag == "Player"){
			//Destroy(col.gameObject);
			//Destroy(gameObject);
		}
	}
}
