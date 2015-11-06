using UnityEngine;
using System.Collections;

public class VillagerD : MonoBehaviour {	//村人D

	StageManager stageManager;
	 public const int afterAugurA = 2;
	 public const int afterAugurB = 3;
	 public const int afterAugurAandB = 4;
	 public const int afterAugurAandBVillagerB = 10;
	 public const int augurAtwice = 11;
	 /* 占い師Aに話しかけた後 == 2
	 	占い師Bに話しかけた後 == 3
	 	占い師AとBに話しかけた後 == 4
	 	占い師Aと占い師Bと村人Bに話しかけた後 == 10
	 	占い師Aに2回話しかけた後 == 11	*/

	 	void ChangeColmn(){
	 		if(stageManager.talkAugurA > 0){
	 			stageManager.condition = afterAugurA;
	 		}
	 		if(stageManager.talkAugurB > 0){
	 			stageManager.condition = afterAugurB;
	 		}
	 		if(stageManager.talkAugurAandB > 0){
	 			stageManager.condition = afterAugurAandB;
	 		}
	 		if(stageManager.talkAugurAandBandVillagerB > 0){
	 			stageManager.condition = afterAugurAandBVillagerB;
	 		}
	 		if(stageManager.talkAugurA >= 2){
	 			stageManager.condition = augurAtwice;
	 		}
	 	}
}
