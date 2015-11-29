using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverFadeIn_4 : MonoBehaviour {

	public UiManager ui;
	public TrackMove tm;
	public GameObject restartBtn, exitBtn;
	public GameObject enemyCars;
	public Text ScoreText, distanceText;
	public CarController control;
	public RevenueManager rev;
	
	
	// Use this for initialization
	void Start () {
		restartBtn.SetActive(false);
		exitBtn.SetActive(false);
		
		//ScoreText.text = "" + control.score;
		//distanceText.text = "" + Braking.distance.ToString("f1");
		//distanceText.text = "" + Braking_Car2.distance.ToString("f1");
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
		ScoreText.text = "" + control.score;
		
		//distanceText.text = "" + Braking.distance.ToString("f1");
		//distanceText.text = "" + Braking_Car2.distance.ToString("f1");
		//distanceText.text = "" + Braking_Car3.distance.ToString("f1");
		distanceText.text = "" + Braking_Car4.distance.ToString("f1");
		
		rev.revenueText.text = "$" + rev.revenue;
	}
}
