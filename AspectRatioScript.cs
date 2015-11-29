using UnityEngine;
using System.Collections;

public class AspectRatioScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Camera.main.aspect = 562f / 900f;
	}
}
