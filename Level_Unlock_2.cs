using UnityEngine;
using System.Collections;

public class Level_Unlock_2 : MonoBehaviour {

	public RevenueManager rev;
	public GameObject unlockBtn;
	public GameObject unlockIcon;
	
	private bool isPressed;
	
	public int unlockNum;
	
	// Use this for initialization
	void Start(){
		if(PlayerPrefs.GetInt("CarLocked") == 1){
			unlockBtn.SetActive(false);
			unlockIcon.SetActive(false);
		}
		
		unlockNum = PlayerPrefs.GetInt("CarLocked", 0);
		isPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown(0)){
			//PlayerPrefs.DeleteAll();
			//revenue = 0;
		}
	}
	
	public void Car_Unlock_2(){
		if(rev.revenue > 10){
			//Application.LoadLevel(name);
			
			unlockBtn.SetActive(false);
			unlockIcon.SetActive(false);
			isPressed = true;
			
			if(rev.revenueText.name == "RevenueText"){
				rev.revenue -= 10;
				rev.revenueText.text = "$" + rev.revenue;
			}
			PlayerPrefs.SetInt("CarLocked", 1);	
		}
		//PlayerPrefs.SetInt("CarLocked", 1);
	}
	
	public void ButtonPressed(){
		if(isPressed == true){
			unlockBtn.SetActive(false);
			unlockIcon.SetActive(false);
		}
		PlayerPrefs.SetInt("CarLocked", 1);
	}
}
