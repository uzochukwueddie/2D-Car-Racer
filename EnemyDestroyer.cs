using UnityEngine;
using System.Collections;

public class EnemyDestroyer : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Enemy"){
			Destroy(col.gameObject);
		}else if(col.gameObject.tag == "Fuel"){
			Destroy(col.gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "Fuel"){
			Destroy(col.gameObject);
		}
	}
}
