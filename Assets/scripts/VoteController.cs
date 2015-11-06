using UnityEngine;
using System.Collections;

public class VoteController : MonoBehaviour {
	StageManager stageManager;

	void Start(){
		stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
		stageManager.NextDay();
	}

	public void LoadScene(string sceneName){
		Application.LoadLevel(sceneName);
	}

	public void ToStage01(){
		Application.LoadLevel("Stage01");
	}

	public void ToDeadAnm(){
		StageManager.votebool = true;
		Application.LoadLevel("DeadAnm");
	}

	public void ToNight(){
		Application.LoadLevel("Nighy");
	}

}
