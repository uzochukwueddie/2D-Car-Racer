using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FuelCar : MonoBehaviour {

	public GameObject fuelCar;
	public float carDelayTimer;
	public Fuel_Reduced fuelReduced;
	
	private float carTimer;
	public static bool isFuelled;
	private int carNo;
	
	// Use this for initialization
	void Start () {
		carTimer = carDelayTimer;
		//isFuelled = true;
	}
	
	// Update is called once per frame
	void Update () {
		carTimer -= Time.deltaTime;
		
		if(carTimer <= 0){
			Vector3 carPos = new Vector3 (Random.Range (-160f, 185f), transform.position.y, transform.position.z);
			carNo = Random.Range(0, 0);
			//Vector3 offset = new Vector3(0, -30f, 0);
			Vector3 startPosition = transform.position + new Vector3(0, -1, 0);
			GameObject playerFuel = Instantiate (fuelCar, startPosition, transform.rotation) as GameObject;
			carTimer = carDelayTimer;
		}
	}
}
