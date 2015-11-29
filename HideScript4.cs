using UnityEngine;
using System.Collections;

public class HideScript4 : MonoBehaviour {

	public GameObject backButton, backButton2;
	public static int unlockNum;
	
	void Awake(){
		
	}
	
	// Use this for initialization
	void Start () {		
		//unlockButton.SetActive(true);
		
		unlockNum = PlayerPrefs.GetInt("UnLock");
		
		backButton.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		IsHidden ();
		
		UnLocked();
		
		if(HideObject1.isBought){
			PlayerPrefs.SetInt("UnLock", 1);
		}
		
		
	}
	
	public void UnLocked(){
		if(unlockNum == 0 && HideObject1.isBought == true){
			backButton.SetActive(true);
			//backButton2.SetActive(false);
		}else if(unlockNum == 1 && HideObject1.isBought == false){
			backButton.SetActive(false);
			//backButton2.SetActive(true);
		}
	}
	
	public void IsHidden(){
		if(HideScript2.unlockNum == 1 && HideObject1.isBought == true){
			backButton.SetActive(true);
			backButton2.SetActive(false);
		}else if(HideScript2.unlockNum == 0 && HideObject1.isBought == false){
			backButton.SetActive(false);
			backButton2.SetActive(true);
		}
	}
}
