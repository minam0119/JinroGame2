using UnityEngine;
using System.Collections;

public class votenext : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void PushNextDay(){
		GameManager.day ++;
		Application.LoadLevel("mainscene");
	}
}
