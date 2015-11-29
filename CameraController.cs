using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	private GameObject target, target1;
	public GameObject TargettoBall, TargettoBall2;
	public float speedZoom = 9;
	//public float size = 10;
	//private float EndZoom = 15;
	
	//public float scrollSpeed = 30;
	private float maxPos = 9;
	//private bool StartLevelMove = true;
	//private bool Zoomedout = false;
	private Camera cam;
	
	
	
	void Start(){
		
		this.cam = (Camera)this.gameObject.GetComponent("Camera");
		
		this.cam.orthographic = true;
		
		this.cam.transform.rotation = Quaternion.Euler(0, 0, 0); 
		
		this.cam.orthographicSize = 450;
		
		target = TargettoBall; 
		target1 = TargettoBall2;
		
		Braking.isPressed = false;
		Braking_Car2.isPressed = false;
		//speedZoom = 9;
		
	}
	
	void Update(){
		
		if (Braking.isPressed == true || Braking_Car2.isPressed == true || Braking_Car3.isPressed == true || Braking_Car4.isPressed == true){
			GetComponent<Camera>().orthographicSize += Time.deltaTime * speedZoom;
			GetComponent<Camera>().orthographicSize = Mathf.Clamp(GetComponent<Camera>().orthographicSize, 450f, 500f);
		}
		
		float distance = 0;

		var go = target.gameObject;
		if (go == null){
			
		}else {
			transform.position = Vector3.Lerp(transform.position, target.transform.position + new Vector3(distance, distance, -distance), 0);
			
			this.cam.transform.LookAt(target.transform);
		}
		
		var go1 = target1.gameObject;
		if (go1 == null){
			
		}else {
			transform.position = Vector3.Lerp(transform.position, target1.transform.position + new Vector3(distance, distance, -distance), 0);
			//this.cam.transform.LookAt(target1.transform);
		}
		
		if (GetComponent<Camera>().orthographicSize <= maxPos){
			speedZoom = 0;
		}
		
	}
	
	/*IEnumerator Changecam(){
		yield return new WaitForSeconds(2f);
		GetComponent<Camera>().orthographicSize += Time.deltaTime * speedZoom;
		StartLevelMove = false;
		while(GetComponent<Camera>().orthographicSize > 6){
			GetComponent<Camera>().orthographicSize -= Time.deltaTime * speedZoom;
			yield return null;
		}
	}*/
}
