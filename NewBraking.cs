using UnityEngine;
using System.Collections;

public class NewBraking : MonoBehaviour {

	public float speed;
	public float minSpeed = 0.1f;
	public float maxSpeed = 150;
	public float Accel = 1f;
	public float decel = 0.1f;
	public EngineSound am;
	
	private Vector2 offset;
	private bool isPressed;
	
	
	// Use this for initialization
	void Start () {
		speed = 0f;
		Accel = 0.1f;
		
	}
	
	
	// Update is called once per frame
	void Update () {
		//This makes the background to scroll
		offset = new Vector2(0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
		
		if(!isPressed){
			BrakeCar();
		}
		//BrakeCar2();
	}
	
	/*public void BrakeCar1(){
		//If there is a touch on screen
		if(Input.touches.Length <= 0){
			//If no touches execute this code
		}else{
			//Loop through all the touches on screen
			for(int i = 0; i < Input.touchCount; i++){
				//If current touch hits our guitexture, run this code
				if(Input.GetTouch(i).phase != TouchPhase.Ended && this.GetComponent<GUITexture>().HitTest(Input.GetTouch(i).position)){
					speed = Accel + Mathf.Clamp(speed, minSpeed, maxSpeed - Accel);
					am.carEngineSound.Play ();
					//am.carEngineSound.volume += 0.001f;
					am.carEngineSound.pitch += 0.1f * Time.deltaTime;
				}else{
					speed = -decel + Mathf.Clamp(speed, minSpeed +Accel, maxSpeed );
				}
			}
		}
	}*/
	
	public void BrakeCar(){
		//If there is a touch on screen
		if(Input.touches.Length <= 0){
			
			//Loop through all the touches on screen
			for(int i = 0; i < Input.touchCount; i++){
				
				//If current touch hits our guitexture, run this code
				if(Input.GetTouch(i).phase != TouchPhase.Ended && this.GetComponent<GUITexture>().HitTest(Input.GetTouch(i).position)){
					speed = -Accel + Mathf.Clamp(speed, minSpeed +Accel, maxSpeed );
					am.carEngineSound.pitch -= 0.1f * Time.deltaTime;
					am.carBrakeSound.Play();
				}else{
					//speed = -decel + Mathf.Clamp(speed, minSpeed +Accel, maxSpeed );
					GetComponent<Rigidbody2D>().velocity = transform.forward * Time.deltaTime * speed;
				}
			}
		}
	}
}
