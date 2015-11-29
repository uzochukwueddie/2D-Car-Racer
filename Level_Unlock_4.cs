using UnityEngine;
using System.Collections;

public class Level_Unlock_4 : MonoBehaviour {

	public RevenueManager rev;
	public GameObject unlockBtn;
	public GameObject unlockIcon;
	
	public int unlockNum3;
	private bool isPressed;
	
	// Use this for initialization
	void Start(){
		if(PlayerPrefs.GetInt("CarLocked3") == 1){
			unlockBtn.SetActive(false);
			unlockIcon.SetActive(false);
		}
		unlockNum3 = PlayerPrefs.GetInt("CarLocked3", 0);
		isPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Car_Unlock_4(){
		if(rev.revenue > 10){
			//Application.LoadLevel(name);
			
			unlockBtn.SetActive(false);
			unlockIcon.SetActive(false);
			isPressed = true;
			
			if(rev.revenueText.name == "RevenueText"){
				rev.revenue -= 10;
				rev.revenueText.text = "$" + rev.revenue;
			}
			PlayerPrefs.SetInt("CarLocked3", 1);			
		}
		//PlayerPrefs.SetInt("CarLocked2", 1);
	}
}
