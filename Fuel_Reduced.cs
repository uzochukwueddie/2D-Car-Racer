using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fuel_Reduced : MonoBehaviour {

	public GameObject fuel_Level_1, fuel_Level_2, fuel_Level_3, fuel_Level_4;
	public float delayTimer;
	
	public float timer, timer2, timer3;
	public float fuelTimer;
	
	// Use this for initialization
	void Start () {
		timer = delayTimer;
		timer2 = delayTimer;
		timer3 = delayTimer;
		fuelTimer = delayTimer;
		
		fuel_Level_1.gameObject.SetActive(true);
		fuel_Level_2.gameObject.SetActive(false);
		fuel_Level_3.gameObject.SetActive(false);
		fuel_Level_4.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(UiManager.isStarted == false){
			timer -= Time.deltaTime;
			timer2 -= Time.deltaTime;
			timer3 -= Time.deltaTime;
			fuelTimer -= Time.deltaTime;
		}
		
		if(timer <= 20f){
			fuel_Level_1.gameObject.SetActive(true);
			fuel_Level_2.gameObject.SetActive(false);
			fuel_Level_3.gameObject.SetActive(false);
			fuel_Level_4.gameObject.SetActive(false);
		}
		
		if(timer <= 15f){
			fuel_Level_1.gameObject.SetActive(false);
			fuel_Level_2.gameObject.SetActive(true);
			fuel_Level_3.gameObject.SetActive(false);
			fuel_Level_4.gameObject.SetActive(false);
		}
		
		if(timer2 <= 10f){
			fuel_Level_1.gameObject.SetActive(false);
			fuel_Level_2.gameObject.SetActive(false);
			fuel_Level_3.gameObject.SetActive(true);
			fuel_Level_4.gameObject.SetActive(false);
		}
		
		if(timer3 <= 5f){
			fuel_Level_1.gameObject.SetActive(false);
			fuel_Level_2.gameObject.SetActive(false);
			fuel_Level_3.gameObject.SetActive(false);
			fuel_Level_4.gameObject.SetActive(true);
			
			if(fuelTimer <= 0){
				//timer = delayTimer;
				//timer2 = delayTimer;
				//timer3 = delayTimer;
				//fuelTimer = delayTimer;
			}
		}
	}
}
