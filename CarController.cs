using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

	public float velocityX, velocityY;
	public float[] limits, topLimits;
	public static bool isDead;
	public UiManager ui;
	public TrackMove trackMove;
	public Fuel_Reduced fuelReduced;
	public EngineSound engineSound;
	//public Text gameOvetText;
	public Text scoreText;
	public GameObject scoreObject;
	public float limitHorizontalPosition, limitVerticalPosition;
	public float carSpeed = 50f;
	//public Text fuelGuage;
	public GameObject gameOverpanel;
	public int score;
	
	//public float fuelLevel;
	private bool isStarted;
	private float mobileStartAcceleration;
	private float HorizontalMovement, VerticalMovement;
	
	
	
	// Use this for initialization
	void Start () {
		score = 0;
		isDead = false;
		isStarted = false;
		mobileStartAcceleration = Input.acceleration.y;
		GetComponent<Renderer>().GetComponent<Renderer>().enabled = true;
		
		scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
		scoreText.text = "Score: " + score;
		
		engineSound.carStartSound.Play();	
		
		gameOverpanel.gameObject.SetActive(false);
		
	}
	
	void FixedUpdate(){
		if(UiManager.isStarted == true){
			HorizontalMovement = 10;
		}else if(UiManager.isStarted == false){
			#if UNITY_WP8 || UNITY_ANDROID || UNITY_IOS
			
			HorizontalMovement  = Input.acceleration.x * velocityX * Time.deltaTime; 
			//VerticalMovement  =  (Input.acceleration.y - mobileStartAcceleration) * velocityY * Time.deltaTime;
			
			Vector3 dir = new Vector3(0, 0, 0);
			dir.x = Input.acceleration.x;
			dir.y = 0;
			dir.z = 0;
			
			if (dir.sqrMagnitude > 1)
				dir.Normalize();
			
			dir *= Time.fixedDeltaTime;
			
			Vector3 position = transform.position += (dir * carSpeed);
			position.x = Mathf.Clamp(position.x, -173f, 198f);
			//carSpeed = Mathf.Lerp(carSpeed, 500f, 0.0001f);
			//GetComponent<Rigidbody2D>().AddForce(dir * carSpeed * Time.deltaTime);
			transform.position = position;
			
			#endif //elif
			
			
			if(isDead == true){
				return;
			}
			
			limitHorizontalPosition += HorizontalMovement;
			limitHorizontalPosition = Mathf.Clamp (limitHorizontalPosition, limits [0], limits [1]);//to clamp the road side limits
			
			limitVerticalPosition += VerticalMovement;
			limitVerticalPosition = Mathf.Clamp (limitVerticalPosition, topLimits [0], topLimits [1]);//to clamp the road up limites
			
			transform.position = new Vector3 (limitHorizontalPosition, limitVerticalPosition, -2);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if(UiManager.isStarted == false){
			fuelReduced.timer -= Time.deltaTime;
			fuelReduced.timer2 -= Time.deltaTime;
			fuelReduced.timer3 -= Time.deltaTime;
			fuelReduced.fuelTimer -= Time.deltaTime;
		}
		
		if(UiManager.isStarted == false){
			score += 10;
			scoreText.text = "Score: " + score;
		}
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Enemy"){
			Destroy (gameObject);
			Destroy (col.gameObject);
			ui.gameOverActivated();
			gameOverpanel.gameObject.SetActive(true);
			scoreText.gameObject.SetActive(false);
			
			engineSound.carDestroy.Play();
			engineSound.carEngineSound.Stop();
		}
		
		if(col.gameObject.tag == "Caution"){
			Destroy (gameObject);
			Destroy (col.gameObject);
			ui.gameOverActivated();
			gameOverpanel.gameObject.SetActive(true);
			scoreText.gameObject.SetActive(false);
			
			engineSound.carDestroy.Play();
			engineSound.carEngineSound.Stop();
		}
		
		if(col.gameObject.tag == "Fuel"){		
			if(fuelReduced.timer <= 20f){
				fuelReduced.timer = fuelReduced.delayTimer;
				fuelReduced.timer2 = fuelReduced.delayTimer;
				fuelReduced.timer3 = fuelReduced.delayTimer;
				fuelReduced.fuelTimer = fuelReduced.delayTimer;
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "Fuel"){		
			if(fuelReduced.timer <= 20f){
				fuelReduced.timer = fuelReduced.delayTimer;
				fuelReduced.timer2 = fuelReduced.delayTimer;
				fuelReduced.timer3 = fuelReduced.delayTimer;
				fuelReduced.fuelTimer = fuelReduced.delayTimer;
			}
		}
	}
	
	
}
