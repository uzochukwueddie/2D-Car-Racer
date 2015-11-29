using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour {

	public GameObject fuelText;
	
	
	// Use this for initialization
	void Start () {
		//fuelText = GameObject.FindGameObjectWithTag("Fuel");//.GetComponent<Text>();
		//fuelText.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			Destroy (gameObject);
			fuelText.gameObject.SetActive(true);
			Vector3 offset = new Vector3(0, 0, 0);
			GameObject fuel = Instantiate(fuelText, transform.position+offset, Quaternion.identity) as GameObject;
			fuel.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 20f, 0);
			Destroy (fuel, 0.3f);
		}
		
		if(col.gameObject.tag == "Enemy"){
			Destroy (gameObject);
			Destroy (col.gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "Player"){
			Destroy (gameObject);
			fuelText.gameObject.SetActive(true);
			Vector3 offset = new Vector3(0, 0, 0);
			GameObject fuel = Instantiate(fuelText, transform.position+offset, Quaternion.identity) as GameObject;
			fuel.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 20f, 0);
			Destroy (fuel, 0.3f);
		}
	}
}
