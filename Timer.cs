using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {
	
	public static Text timeText;
	public static float timeElapsed = 0.0f;
	public static bool gameStarted;
	
	private TimeManager timeManager;
	
	// Use this for initialization
	void Start () {
		timeManager = GetComponent<TimeManager>();
		timeText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!UiManager.isStarted && Time.timeScale == 0){
			if(Input.GetMouseButtonDown(0)){
				timeManager.ManipulateTime(1f, 1f);
				gameStarted = false;
			}
		}
		
		if(UiManager.isStarted){
			timeText.text = "TIME: " + FormatTime(timeElapsed);
		}else{
			timeElapsed += Time.deltaTime;
			timeText.text = "TIME: " + FormatTime(timeElapsed);
		}
	}
	
	public static void Reset1(){
		if (gameStarted == false && Time.timeScale == 1) {
			timeElapsed += Time.deltaTime;
			timeText.text = "TIME: " + FormatTime(timeElapsed);
		}else{
			timeText.text = "TIME: " + FormatTime (timeElapsed); 
		}
	}
	
	public static string FormatTime(float value){
		TimeSpan t = TimeSpan.FromSeconds(value);
		return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
	}
}
