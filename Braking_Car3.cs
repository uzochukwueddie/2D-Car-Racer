using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Braking_Car3 : MonoBehaviour {

	public TrackMove tm;
	public UiManager ui;
	public EngineSound am;
	private EnemyCarMovement enemyCarMove;
	public static float distance;
	public Text speedText, distanceText;
	
	public static bool isPressed;
	
	// Use this for initialization
	void Start () {
		isPressed = false;
		tm.speed = 0;
		tm.Accel = 1;
		
		//speedText = GameObject.FindGameObjectWithTag("Speed").GetComponent<Text>();
		speedText.text = "Speed: " + tm.speed;
		
		distanceText = GameObject.FindGameObjectWithTag("Distance").GetComponent<Text>();
		distanceText.text = "Distance: " + distance;
	}
	
	void FixedUpdate(){
		if (ui.gameOver == true){
			UiManager.isStarted = true;
			speedText.gameObject.SetActive(false);
			distanceText.gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		NewPress();
		
		if(isPressed == false){
			buttonUp1();
		}
		
		if(UiManager.isStarted == false){
			speedText.gameObject.SetActive(true);
			distanceText.gameObject.SetActive(true);
			
			distance += 0.1f * Time.smoothDeltaTime;
			distanceText.text = "Distance: " + distance.ToString("f1");
			
		}
		
		
	}	
	
	public void NewPress(){
		if (Input.touchCount > 0){
			if(isPressed && Input.GetTouch(0).phase == TouchPhase.Stationary){
				tm.speed = (tm.Accel + Mathf.Clamp(tm.speed, tm.minSpeed, tm.maxSpeed));
				am.carEngineSound.Play ();
				am.carEngineSound.pitch += 0.1f * Time.fixedDeltaTime;
				EnemyCarMovement.speed = 600f;
				//tm.speed += 1f * Time.smoothDeltaTime;
				speedText.text = "Speed: " + tm.speed;
				
				//distance += 1f * Time.smoothDeltaTime;
				//distanceText.text = "Distance: " + distance.ToString("f1");
			}
		}
	}	
			
	
	public void buttonDown(){
		isPressed = true;
		//tm.speed = -tm.decel + Mathf.Clamp(tm.speed, tm.minSpeed + tm.Accel, tm.maxSpeed);
	}
	
	public void buttonUp(){
		isPressed = false;
	}
	
	public void buttonUp1(){
		tm.speed = -tm.decel + Mathf.Clamp(tm.speed, tm.minSpeed + tm.Accel, tm.maxSpeed);
		speedText.text = "Speed: " + tm.speed.ToString("f1");
	}
	
}
