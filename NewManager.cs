using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewManager : MonoBehaviour {

	public RevenueManager rev;
	public GameObject panel;
	public GameObject unlockBtn;
	
	void Start(){
		panel.SetActive(false);
	}
	
	
	void Update(){
		
	}
	
	public void NotEnough(){
		if(rev.revenue < 10){
			panel.SetActive(true);
		}
	}
	
	public void NotEnough2(){
		if(rev.revenue <= 20){
			panel.SetActive(true);
		}
	}
}
