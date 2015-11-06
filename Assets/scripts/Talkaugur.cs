using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Talkaugur : MonoBehaviour {

	public TextAsset talk_csv;
	public Text TalkText;
	string[,] talks;

	// Use this for initialization
	void Start () {
		talks = CSVReader.SplitCsvGrid(talk_csv.text);
		TalkText.text = SplitNewLine(talks[GameManager.day,0]);

	}
	
	// Update is called once per frame
	void Update () {
		if(GameManager.day == 1){
			TalkText.text = talks[GameManager.day,0];
		}
	
	}

	string SplitNewLine(string talk){
		string[] bunkatu = talk.Split(':');
		string kaigyou = "";
		for(int i=0; i<bunkatu.Length; i++){
			kaigyou += bunkatu[i] + "\n";
		}
		return kaigyou;
	}
}
