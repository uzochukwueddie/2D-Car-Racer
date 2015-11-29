using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sound : MonoBehaviour {
	
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
			audioSource = GetComponent<AudioSource>();
			audioSource.volume = 0.4f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			//StartSound();
		}
	}
	
	public void StartSound(){
		
	}
}
