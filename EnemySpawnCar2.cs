using UnityEngine;
using System.Collections;

public class EnemySpawnCar2 : MonoBehaviour {

	public GameObject car2;
	public float car2Delay;
	public float speed;
	
	private float car2Time;
	private int carNo;
	
	// Use this for initialization
	void Start () {
		car2Time = car2Delay;
	}
	
	// Update is called once per frame
	void Update () {
		car2Time -= Time.deltaTime;
		
		if(car2Time <= 0){
			Vector3 carPos = new Vector3 (Random.Range (-175f, 200f), transform.position.y, transform.position.z);
			carNo = Random.Range(0, 1);
			Vector3 startPosition = transform.position + new Vector3(0, -1, 0);
			GameObject car2Object = Instantiate (car2, startPosition, transform.rotation) as GameObject;
			car2Object.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
			car2Time = car2Delay;
		}
	}
}
