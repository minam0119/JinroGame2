using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JinroGame;
using UnityStandardAssets.Characters.FirstPerson;


public class StageManager : MonoBehaviour {
	static List<int> deadCharcteNum = new List<int>();
	static List<CharacterViewController> actors = new List<CharacterViewController>();
	public int date = 0;
	public int rest;//各クラス
	public int condition = 1;
	public int talkAugurA,talkAugurB,talkAugurAandB,talkVillagerA,talkVillagerB,
				talkVillagerC,talkVillagerD,talkmidium,talkAugurAandAugurBandVillagerA,
				talkAugurAandBandVillagerB,talkAugurAandBandVillagerD = 0;
	public static bool votebool = false;
	private static StageManager singleInstance;
	TextAsset scenario;


	CharacterViewController[] character;

	void Awake(){

		//シーンをまたいでも消えないオブジェクト
		if(singleInstance == null){
			singleInstance = this;
			GameObject.DontDestroyOnLoad(this.gameObject);
		}else{
			GameObject.Destroy(this.gameObject);
		}
	}

	public void NextDay(){
		date = date +1;
		print("日付:" + date.ToString());
	}
}
