using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Braking1 : MonoBehaviour, IEventSystemHandler {

	public TrackMove tm;
	public EngineSound am;
	private EnemyCarMovement enemyCarMove;
	public EnemyCarSpawner enemyBrake;
	
	public static bool isNotPressed;
	
	
	// Use this for initialization
	void Start () {
		isNotPressed = false;
		tm.speed = 0.1f;
		tm.Accel = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(isNotPressed == true) {
			isNotPressed = true;
			//tm.speed = -tm.Accel + Mathf.Clamp(tm.speed, tm.minSpeed + tm.Accel, tm.maxSpeed );
			isNotPressed = true;
			tm.speed = 1f;
			am.carEngineSound.pitch -= 0.1f * Time.deltaTime;
			am.carBrakeSound.Play();
			
			EnemyCarMovement.speed = -300f;
		}
		if(Input.touchCount > 1) {
			if(Input.GetTouch(0).phase == TouchPhase.Began){
				buttonDown();
			}
			
			if(Input.GetTouch(0).phase == TouchPhase.Ended){
				buttonUp();
			}
			
		}
	}		
	
	
	public void buttonDown(){
		//GetComponent<SpriteRenderer>().sprite = after;
		isNotPressed = true;
	}
	
	public void buttonUp(){
		//GetComponent<SpriteRenderer>().sprite = after;
		isNotPressed = false;
	}
	
}
