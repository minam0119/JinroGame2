using UnityEngine;
using System.Collections;

public class TouchToMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TouchChangeScene(){
		Application.LoadLevel("main");
	}
}
