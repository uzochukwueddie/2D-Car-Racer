using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	public Text countDownText;
	
	// Use this for initialization
	void Start () {
		Braking.isPressed = false;
		
		if(Braking.isPressed == true){
			StartCoroutine(CountDownText());
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator CountDownText(){
		yield return new WaitForSeconds(1);
		countDownText.text = "3";
		
		yield return new WaitForSeconds(1);
		countDownText.text = "2";
		
		yield return new WaitForSeconds(1);
		countDownText.text = "1";
		
		yield return new WaitForSeconds(1);
		countDownText.text = "GO!";
	}
}
