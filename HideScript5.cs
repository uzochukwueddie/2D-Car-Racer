using UnityEngine;
using System.Collections;

public class HideScript5 : MonoBehaviour {

	public GameObject backButton, backButton2;
	public static int unlockNum;
	
	// Use this for initialization
	void Start () {		
		//unlockButton.SetActive(true);
		//backButton.SetActive(false);
		//backButton2.SetActive(false);
		
		unlockNum = PlayerPrefs.GetInt("UnLockNum");
		//HideScript3.unlockNum = PlayerPrefs.GetInt("UnLock");
	}
	
	// Update is called once per frame
	void Update () {
		//IsHidden ();
		
		UnLocked();
		
		if(HideObject.isBought){
			PlayerPrefs.SetInt("UnLockNum", 1);
		}
	}
	
	public void UnLocked(){
		if(unlockNum == 0 && HideObject.isBought == false){
			backButton.SetActive(true);
			backButton2.SetActive(false);
		}else if(unlockNum == 1 && HideObject.isBought == true){
			//backButton.SetActive(false);
			backButton2.SetActive(true);
		}
	}
	
	public void IsHidden(){
		if(HideScript3.unlockNum == 0){
			backButton.SetActive(true);
			backButton2.SetActive(false);
		}else if(HideScript2.unlockNum == 1){
			backButton.SetActive(false);
			backButton2.SetActive(true);
		}
	}
}
