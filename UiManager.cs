using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

	public TrackMove tm;
	//public GameObject startBtn;
	public Text countDownText;
	public GameObject btn1, btn2, enemyCars;
	
	public bool gameOver;
	public static bool isStarted;
	public static bool pause;
	private AudioSource audioSource;
	
	void Start(){
		gameOver = false;
		isStarted = true;	
		pause = false;
		
		btn1.SetActive(false);
		btn2.SetActive(false);
		enemyCars.gameObject.SetActive(false);

		if(Time.timeScale == 1 && isStarted == true){
			countDownText.gameObject.SetActive(true);
			StartCoroutine(CountDownText());
		}	
	}
	
	void Update(){
		if(isStarted == false){
			btn1.SetActive(true);
			btn2.SetActive(true);
			enemyCars.gameObject.SetActive(true);
		}
	}
	
	public void StartGame(){
		if(!isStarted){
			//Time.timeScale = 1;
			//startBtn.SetActive(false);
		}
		isStarted = false;
	}
	
	public void StartSound(){
		audioSource = GetComponent<AudioSource>();
		audioSource.volume = 0.5f;
	}
	
	public void gameOverActivated(){
		gameOver = true;
	}
	
	public void Pause(){
		pause = !pause;
		
		if(pause){
			Time.timeScale = 0;
			isStarted = true;
		}else if(!pause){
			Time.timeScale = 1;
			isStarted = false;
		}
	}
	
	IEnumerator CountDownText(){
		yield return new WaitForSeconds(1);
		countDownText.text = "READY!";
		
		yield return new WaitForSeconds(1);
		countDownText.text = "3";
		
		//yield return new WaitForSeconds(1);
		//countDownText.text = "2";
		
		//yield return new WaitForSeconds(1);
		//countDownText.text = "1";
		
		yield return new WaitForSeconds(1);
		countDownText.text = "GO!";
		
		yield return new WaitForSeconds(1);
		countDownText.gameObject.SetActive(false);
		
		yield return new WaitForSeconds(0.1f);
		isStarted = false;
	}
}
