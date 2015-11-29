using UnityEngine;
using System.Collections;

public class Level_Unlock_3 : MonoBehaviour {

	public RevenueManager rev;
	public GameObject unlockBtn;
	public GameObject unlockIcon;
	
	public int unlockNum2;
	private bool isPressed;
	
	// Use this for initialization
	void Start(){
		if(PlayerPrefs.GetInt("CarLocked2") == 1){
			unlockBtn.SetActive(false);
			unlockIcon.SetActive(false);
		}
		unlockNum2 = PlayerPrefs.GetInt("CarLocked2", 0);
		isPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Car_Unlock_3(){
		if(rev.revenue > 10){
			//Application.LoadLevel(name);
			
			unlockBtn.SetActive(false);
			unlockIcon.SetActive(false);
			isPressed = true;
			
			if(rev.revenueText.name == "RevenueText"){
				rev.revenue -= 10;
				rev.revenueText.text = "$" + rev.revenue;
			}
			PlayerPrefs.SetInt("CarLocked2", 1);			
		}
		//PlayerPrefs.SetInt("CarLocked2", 1);
	}
}
