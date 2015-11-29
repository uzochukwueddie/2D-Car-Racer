using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewHideScript : MonoBehaviour {

	public GameObject button, button1;
	public int unlockNumber;
	//public GameObject gObject;	
	
	// Use this for initialization
	void Start () {
		button.SetActive(false);
		//button1.SetActive(false);
		
		unlockNumber = PlayerPrefs.GetInt("UnLockNumber");
		
	}
	
	// Update is called once per frame
	void Update () {
		if(unlockNumber == 0 && HideObject.isBought == false){
			button.SetActive(true);
			button1.SetActive(false);
		}else if(unlockNumber == 1 && HideObject.isBought == true){
			button.SetActive(false);
			button1.SetActive(true);
		}
		
		if(HideObject.isBought){
			PlayerPrefs.SetInt("UnLockNumber", 1);
		}
	}
}
