﻿using UnityEngine;
using System.Collections;

public class toMain : MonoBehaviour {
	float time = 4;

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
