using UnityEngine;
using System.Collections;

public class HideScript_4 : MonoBehaviour {

	public GameObject button;
	public int unlockNumber1;
	
	// Use this for initialization
	void Start () {
		//button.SetActive(false);
		unlockNumber1 = PlayerPrefs.GetInt("UnLockNumber1");	
	}
	
	// Update is called once per frame
	void Update () {
		if(unlockNumber1 == 1 && HideObject1.isBought == true){
			button.SetActive(true);
		}
		
		if(HideObject.isBought){
			PlayerPrefs.SetInt("UnLockNumber1", 1);
		}
	}
}
