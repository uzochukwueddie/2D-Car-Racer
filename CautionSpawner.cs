using UnityEngine;
using System.Collections;

public class CautionSpawner : MonoBehaviour {

	public GameObject caution;
	public float cautionDelay;
	public float speed;
	
	private float cautionTime;
	
	// Use this for initialization
	void Start () {
		cautionTime = cautionDelay;
	}
	
	// Update is called once per frame
	void Update () {
		cautionTime -= Time.deltaTime;
		
		if(cautionTime <= 0){
			Vector3 startPosition = transform.position + new Vector3(0, -1, 0);
			GameObject cautionObject = Instantiate (caution, startPosition, transform.rotation) as GameObject;
			cautionObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
			cautionTime = cautionDelay;
		}
	}
}
