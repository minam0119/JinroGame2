using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class AugurControlerView : MonoBehaviour {
	bool judgeWerewolf = false;
	
	// Use this for initialization
	void Start () {

		//人間(白)と判定される人
		var human = (
			from h in StageManager.instance.characters
			where h.data.role != (int)Const.ActType.Werewolf
			select h).ToList();
		//生き残っている人
		var survivor = (
			from s in StageManager.instance.characters
			where s.data.isLive == true
			select s).ToList();
		for (int i = 0; i >= survivor.Count; i++) {

		}
		
		
		human[0].data.role;
	}
	
	public void Judge (CharacterData data) {
		if(data.role == (int)Const.ActType.Werewolf){
			judgeWerewolf = true;
		}
		if(judgeWerewolf == true) {

		}
	}
}
