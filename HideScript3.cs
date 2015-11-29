using UnityEngine;
using System.Collections;

public class HideScript3 : MonoBehaviour {

	public GameObject unlockBtn, unlockBtn2;
	public static int unlockNum;
	
	// Use this for initialization
	void Start () {		
		unlockBtn.SetActive(true);
		unlockBtn2.SetActive(false);
		
		unlockNum = PlayerPrefs.GetInt("UnLock");
		HideScript2.unlockNum = PlayerPrefs.GetInt("UnLock");
	}
	
	// Update is called once per frame
	void Update () {
		IsHidden ();
		IsHidden1();
		UnLocked();
	}
	
	public void UnLocked(){
		if(unlockNum == 0){
			unlockBtn.SetActive(true);
			unlockBtn2.SetActive(false);
		}else if(unlockNum == 1){
			unlockBtn.SetActive(false);
			unlockBtn2.SetActive(true);
		}
	}
	
	public void IsHidden(){
		if(HideScript2.unlockNum == 1){
			unlockBtn.SetActive(false);
			unlockBtn2.SetActive(true);
		}else if(HideScript2.unlockNum == 0){
			unlockBtn.SetActive(true);
			unlockBtn2.SetActive(false);
		}
	}
	
	public void IsHidden1(){
		if(HideScript1.unlockNum == 1){
			unlockBtn.SetActive(false);
			unlockBtn2.SetActive(true);
		}else if(HideScript1.unlockNum == 0){
			unlockBtn.SetActive(true);
			unlockBtn2.SetActive(false);
		}
	}
}
