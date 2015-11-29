using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Settings_Panel : MonoBehaviour {

	public GameObject settingsPanel;
	
	// Use this for initialization
	void Start () {
		settingsPanel.SetActive(false);
	}
	
	public void ClosePanel(){
		settingsPanel.SetActive(true);
	}
}
