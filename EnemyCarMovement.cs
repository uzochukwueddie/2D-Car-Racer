using UnityEngine;
using System.Collections;

public class EnemyCarMovement : MonoBehaviour {

	public static float speed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
		EnemyCar();
	}
	
	public void EnemyCar(){
		if (CarController.isDead) {
			transform.Translate (-Vector3.up * -speed * Time.deltaTime);
		}else{ 
			transform.Translate (-Vector3.up * speed * Time.deltaTime);
		}
	}
}
