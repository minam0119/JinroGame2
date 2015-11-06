using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TalkManagaer : MonoBehaviour {

		public Text talkText;
		public TextAsset csv;

		int row = 0;
		int col = 4;

		/*string[,] talks = {
			{"今日の天気いいね","two"	,"yamada"},
			{"ハラヘッタ"		,"four"	,"tanaka"},
			{"魚食いてえ"		,"six"	,"areku"}
		};*/
		string[,] talks;

	// Use this for initialization
	void Start () {

		talks = CSVReader.SplitCsvGrid(csv.text);
		row = 0;
		col = 4;

		talkText.text = talks[col,0] + " : " + talks[col,row];

		//print(talks[row,cal]);
		talkText.text = talks[col,row];
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("right")){
			row++;
			//print(talks[row,cal]);
			talkText.text = talks[col,row];
			talkText.text = talks[col,0] + " : " + talks[col,row];
		}
	
	}
}
