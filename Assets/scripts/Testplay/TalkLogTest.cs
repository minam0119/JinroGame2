using UnityEngine;
using System.Collections;

public class TalkLogTest : MonoBehaviour {
	string a = "山田君";
	string b = "アウトー!";
	string c = "選手交代!";
	string d = "背番号18番";
	string e = "松坂大輔";

	// Use this for initialization
	void Start () {
		a += b + c + d + e;
		print(a);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
