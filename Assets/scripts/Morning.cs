using UnityEngine;
using System.Collections;

public class Morning : MonoBehaviour {
	float time = 4.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if(time <= 0){
			Application.LoadLevel("Stage01");
		}
	}
}
