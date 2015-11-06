using UnityEngine;
using System.Collections;

public class AugurA : MonoBehaviour {	//占い師A

	StageManager stageManager;
	 public const int twice = 5;
	 // 2回目に話しかける == 5

	 	void ChangeColmn(){
	 		if(stageManager.talkAugurA >= 2)stageManager.condition = twice;
	 	}
}
