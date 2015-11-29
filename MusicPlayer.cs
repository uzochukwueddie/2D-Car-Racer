using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	public static MusicPlayer instance = null;
	
	private AudioSource audioSource;
	
	// Use this for initialization
	void Awake () {
		if(instance != null){ // If an instance of the game object already exists, then destroy.
			Destroy (gameObject);
		}else {//if(!Timer.gameStarted){
			instance = this; // instance = this is an instance of the global variable.
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	void Start(){
		audioSource = GetComponent<AudioSource>();
		
		audioSource.volume = 0.4f;
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt("SaveToggle", 1);
	}
}
