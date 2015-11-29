using UnityEngine;
using System.Collections;

public class HideScript1 : MonoBehaviour {

	public GameObject unlockBtn; //unlockBtn3;
	public static int unlockNum;
	
	// Use this for initialization
	void Start () {		
		
		unlockBtn.SetActive(true);
		//unlockBtn2.SetActive(false);
		
		unlockNum = PlayerPrefs.GetInt("UnLock");
		HideScript3.unlockNum = PlayerPrefs.GetInt("UnLock");
		HideScript2.unlockNum = PlayerPrefs.GetInt("UnLock");
		HideScript4.unlockNum = PlayerPrefs.GetInt("UnLock");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("up")){
			PlayerPrefs.DeleteAll();
		}
		
		IsHidden();
		IsHidden1();
		//IsHidden2();
		UnLocked();
	}
	
	public void UnLocked(){
		if(unlockNum == 0){
			unlockBtn.SetActive(true);
			//unlockBtn2.SetActive(true);
		}else if(unlockNum == 1){
			unlockBtn.SetActive(false);
			//unlockBtn2.SetActive(false);
		}
		
	}
	
	public void IsHidden(){
		if(HideScript4.unlockNum == 0){
			unlockBtn.SetActive(true);
			//unlockBtn2.SetActive(false);
		}else if(HideScript4.unlockNum == 1){
			unlockBtn.SetActive(false);
			//unlockBtn2.SetActive(false);
		}
	}
	
	public void IsHidden1(){
		if(HideScript2.unlockNum == 0){
			unlockBtn.SetActive(false);
			//unlockBtn2.SetActive(true);
		}else if(HideScript2.unlockNum == 1){
			unlockBtn.SetActive(true);
			//unlockBtn2.SetActive(false);
		}
	}
	
	public void IsHidden2(){
		if(HideObject.isBought == false){
			unlockBtn.SetActive(true);
		}else if(HideObject.isBought == true){
			unlockBtn.SetActive(false);
		}
	}
	
	
}
