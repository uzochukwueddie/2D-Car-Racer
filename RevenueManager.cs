using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RevenueManager : MonoBehaviour {

	//public static RevenueManager instance = null;
	public int revenue;
	public Text revenueText;
	
	void Awake () {
		
	}
	
	// Use this for initialization
	void Start () {
		//This is used to get the value of the revenue which is an integer
		PlayerPrefs.GetInt("revenuePrefs");
		//Set the revenue equal to the getint
		revenue = PlayerPrefs.GetInt("revenuePrefs");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			//PlayerPrefs.DeleteAll();
			//revenue = 0;
		}
	
		if(revenueText.name == "RevenueText"){
			//revenue += 1;
			revenueText.text = "$" + revenue;
		}
		PlayerPrefs.SetInt("revenuePrefs", revenue);
	}
}
