using UnityEngine;
using System.Collections;

public class EnemyCarSpawner : MonoBehaviour {

	public GameObject[] cars;
	public float maxPox = 258f;
	public float delayTimer = 5f;
	public RevenueManager rev;
	//public float speed;
	
	private float timer;
	private int carNo;
	
	// Use this for initialization
	void Start () {
		//Instantiate(car, transform.position, transform.rotation);
		timer = delayTimer;
	}
	
	void FixedUpdate(){
		timer -= Time.deltaTime;
		
		if(Braking.isPressed == true || Braking_Car2.isPressed == true || Braking_Car3.isPressed == true || Braking_Car4.isPressed == true){
			//transform.Translate (-Vector3.up * speed * Time.fixedDeltaTime);
			if (timer <= 0) {
				Vector3 carPos = new Vector3 (Random.Range (-160f, 185f), transform.position.y, transform.position.z);
				carNo = Random.Range(0, 3);
				Vector3 startPosition = transform.position + new Vector3(0, -1, 0);
				GameObject enemyCar = Instantiate (cars[carNo], startPosition, transform.rotation) as GameObject;
				//enemyCar.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed*Time.deltaTime);
				rev.revenue += 10;
				timer = delayTimer;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
	
		// We created a temporary position for our car which is
		// random created for the x component but the y and z are from the same place.
		if (timer <= 0) {
			Vector3 carPos = new Vector3 (Random.Range (-160f, 185f), transform.position.y, transform.position.z);
			carNo = Random.Range(0, 1);
			GameObject enemyCar = Instantiate (cars[carNo], carPos, transform.rotation) as GameObject;
			//enemyCar.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
			rev.revenue += 10;
			timer = delayTimer;
		}
		
	}
}
