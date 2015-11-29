using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverFadeIn4 : MonoBehaviour {

	public UiManager ui;
	public TrackMove tm;
	public GameObject restartBtn, exitBtn;
	public GameObject enemyCars;
	public Text distanceText;
	public CarController control;
	public Text timeText;
	public RevenueManager rev;
	
	// Use this for initialization
	void Start () {
		restartBtn.SetActive(false);
		exitBtn.SetActive(false);
		
		//ScoreText.text = "" + control.score;
		//distanceText.text = "" + Braking.distance.ToString("f1");
		//distanceText1.text = "" + Braking_Car2.distance.ToString("f1");
		//distanceText.text = "" + Braking_Car3.distance.ToString("f1");
		//distanceText.text = "" + Braking_Car4.distance.ToString("f1");
		//rev.revenueText.text = "$" + rev.revenue;
	}
	
	// Update is called once per frame
	void Update () {
		if(ui.gameOver == true){
			restartBtn.SetActive(true);
			exitBtn.SetActive(true);
			enemyCars.SetActive(false);
			tm.speed = 0.1f;
			Reset ();
		}
	}
	
	void Reset(){
		//ScoreText.text = "" + control.score;
		distanceText.text = "" + Braking_Car4.distance.ToString("f1");
		timeText.text = "" + Timer.FormatTime(Timer.timeElapsed);
		rev.revenueText.text = "$" + rev.revenue;
	}
}
