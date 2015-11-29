using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrackMove : MonoBehaviour {

	public float speed;
	public float minSpeed = 0.1f;
	public float maxSpeed = 150;
	public float Accel = 1;
	public float decel = 1;
	public EngineSound am;
	
	private Vector2 offset;
	public bool isPressed;
	
	// Use this for initialization
	void Start () {
		speed = 0.1f;
		Accel = 1;
		isPressed = false;
	}
	
	void FixedUpdate(){
		
	}
	
	
	// Update is called once per frame
	void Update () {
		//This makes the background to scroll
		offset = new Vector2(0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
		
		//BrakeCar();
	}
		
	/*public void BrakeCar(){
		if(Input.GetKey("up")){
			speed = Accel + Mathf.Clamp(speed, minSpeed, maxSpeed);
			am.carEngineSound.Play ();
			am.carEngineSound.pitch += 0.1f * Time.deltaTime;
		}
		else {
			speed = -decel + Mathf.Clamp(speed, minSpeed +Accel, maxSpeed );
			//am.carBrakeSound.Play();
		}
		
		if (Input.GetKey("down")){
			speed = -Accel + Mathf.Clamp(speed, minSpeed +Accel, maxSpeed );
			am.carEngineSound.pitch -= 0.1f * Time.deltaTime;
			am.carBrakeSound.Play();
		}else if(Input.GetKey("down") && speed > Accel){
			am.carBrakeSound.Play();
		}{
			//am.carBrakeSound.Play();
		}
		
		if(Input.GetKey("up")){
			GetComponent<Rigidbody2D>().velocity = transform.forward * Time.deltaTime * speed;
			//Apply velocity in Update()
		}
	}*/
	
}
