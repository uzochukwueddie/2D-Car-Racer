using UnityEngine;
using System.Collections;

public class HideScript2 : MonoBehaviour {

	public GameObject unlockBtn, unlockBtn2, unlockBtn3;
	public static int unlockNum;
	
	// Use this for initialization
	void Start () {		
		unlockBtn.SetActive(true);
		unlockBtn2.SetActive(true);
		unlockBtn3.SetActive(true);
		
		unlockNum = PlayerPrefs.GetInt("UnLock");
		HideScript4.unlockNum = PlayerPrefs.GetInt("UnLock");
	}
	
	void FixedUpdate(){
		//UnLocked();
	}
	
	// Update is called once per frame
	void Update () {
		IsHidden ();
		
		UnLocked();
	}
	
	public void UnLocked(){
		if(unlockNum == 0){
			unlockBtn.SetActive(true);
			unlockBtn2.SetActive(false);
			unlockBtn3.SetActive(false);
		}else if(unlockNum == 1){
			unlockBtn.SetActive(false);
			unlockBtn2.SetActive(true);
			unlockBtn3.SetActive(false);
		}
	}
	
	public void IsHidden(){
		if(HideScript4.unlockNum == 1){
			unlockBtn.SetActive(false);
			unlockBtn2.SetActive(false);
			unlockBtn3.SetActive(true);
		}else if(HideScript4.unlockNum == 0){
			unlockBtn.SetActive(true);
			unlockBtn2.SetActive(false);
			unlockBtn3.SetActive(false);
		}
	}
}
