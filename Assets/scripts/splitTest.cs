using UnityEngine;
using System.Collections;

public class splitTest : MonoBehaviour {

	string satou = "いろはに;ほへと;ちりぬるを;わかよたれそ;";

	// Use this for initialization
	void Start () {
		 print(SplitNewLine(satou));
	}

	string SplitNewLine(string talk){
		string[] bunkatu = talk.Split(';');
		string kaigyou = "";
		for(int i=0; i<bunkatu.Length; i++){
			kaigyou += bunkatu[i] + "\n";
		}
		return kaigyou;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
