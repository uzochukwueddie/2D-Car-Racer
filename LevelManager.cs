using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public RevenueManager rev;

	void Update(){
		
	}

	public void LoadLevel(string name){
		Application.LoadLevel(name);
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void UnlockLevel(string name){
		if(rev.revenue > 10){
			Application.LoadLevel(name);
			
			if(rev.revenueText.name == "RevenueText"){
				rev.revenue -= 10;
				rev.revenueText.text = "$" + rev.revenue;
			}
			PlayerPrefs.SetInt("revenuePrefs", rev.revenue);
			PlayerPrefs.Save();
		}
	}
	
	public void NoUnlockLevel(string name){
		Application.LoadLevel(name);
	}
	
	public void LockedLevel(string name){
		Application.LoadLevel(name);
	}
	
	public void Back(string name){
		
	}
	
	public void QuitLevel(){
		Application.Quit();
	}
}
