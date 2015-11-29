using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour {

	public AudioSource audioSource;
	public Image toggleBtn;
	
	public int saveToggle;
	private bool muteToggle;
	
	void Awake(){
		
	}
	
	// Use this for initialization
	void Start () {
		muteToggle = true;
		if(PlayerPrefs.GetInt("ToggleOff") == 1){
			toggleBtn.enabled = true;
			
		}else if(PlayerPrefs.GetInt("ToggleOff") == 0){
			toggleBtn.enabled = false;
		}
		
		saveToggle = PlayerPrefs.GetInt("ToggleOff", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Toggle(){
		muteToggle = !muteToggle;
		
		if(muteToggle == false){
			AudioListener.pause = true;
			muteToggle = false;
			//audioSource.Play();
		}else{
			AudioListener.pause = false;
			muteToggle = true;
			//audioSource.Stop();
		}
		PlayerPrefs.SetInt("ToggleOff", 1);
	}
}
