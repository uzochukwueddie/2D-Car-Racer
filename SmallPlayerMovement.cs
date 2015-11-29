using UnityEngine;
using System.Collections;

public class SmallPlayerMovement : MonoBehaviour {

	public float velocityX, velocityY;
	public float[] limits, topLimits;
	public float limitHorizontalPosition, limitVerticalPosition;
	
	private float mobileStartAcceleration;
	private float HorizontalMovement, VerticalMovement;
	
	// Use this for initialization
	void Start () {
		mobileStartAcceleration = Input.acceleration.y;
		Braking.isPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Braking.isPressed == true){
			//HorizontalMovement  = Input.acceleration.x * velocityX * Time.deltaTime; 
			//VerticalMovement  =  (Input.acceleration.y - mobileStartAcceleration) * velocityY * Time.deltaTime;
			VerticalMovement += velocityY * Time.deltaTime;
			
			limitHorizontalPosition += HorizontalMovement;
			limitHorizontalPosition = Mathf.Clamp (limitHorizontalPosition, limits [0], limits [1]);//to clamp the road side limits
			
			limitVerticalPosition += VerticalMovement;
			limitVerticalPosition = Mathf.Clamp (limitVerticalPosition, topLimits [0], topLimits [1]);//to clamp the road up limites
			
			transform.position = new Vector3 (limitHorizontalPosition, limitVerticalPosition, -2);
			
			if(limitVerticalPosition == 220f){
				Braking.isPressed = false;
				Time.timeScale = 0;
			}
		}
		
	}
}
