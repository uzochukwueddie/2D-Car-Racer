using UnityEngine;
using System.Collections;

public class HideObject1 : MonoBehaviour {

	public GameObject hideBtn;
	public GameObject unlockBtn;
	public GameObject nextBtn;
	public RevenueManager rev;
	
	public static int unlockNum;
	
	public static bool isBought;
	
	// Use this for initialization
	void Start () {
		//PlayerPrefs.GetInt("unLock");
		//unlockNum = PlayerPrefs.GetInt("umLock");
		isBought = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isBought){
			PlayerPrefs.SetInt("UnLock", 1);
		}
	}
	
	public void UnLocked(string name){
		if(rev.revenue > 10){
			Application.LoadLevel(name);
			
			hideBtn.SetActive(false);
			unlockBtn.SetActive(false);
			nextBtn.SetActive(true);
			isBought = true;
			
			if(rev.revenueText.name == "RevenueText"){
				rev.revenue -= 10;
				rev.revenueText.text = "$" + rev.revenue;
			}
		}
	}
	
	public void UnLocked2(){
		if(rev.revenue > 10){
			//Application.LoadLevel(name);
			
			hideBtn.SetActive(false);
			unlockBtn.SetActive(false);
			nextBtn.SetActive(true);
			isBought = true;
			
			if(rev.revenueText.name == "RevenueText"){
				rev.revenue -= 10;
				rev.revenueText.text = "$" + rev.revenue;
			}
		}
	}
}
