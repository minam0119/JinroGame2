using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	float time = 60f;
	Text timetx;

	// Use this for initialization
	void Start () {
		print(time);
	}
	
	// Update is called once per frame
	void Update () {
		this.time -= Time.deltaTime;
		timetx.text = Mathf.Floor(this.time).ToString();

	}
}
