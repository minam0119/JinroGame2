using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	private static GameManager singleInstance;

	


	void Awake(){
		if(singleInstance == null){
			singleInstance = this;
			//シーンをまたいでも消えないオブジェクト
			GameObject.DontDestroyOnLoad(this.gameObject);
		}else{
			GameObject.Destroy(this.gameObject);
		}
	}

	public class Character {
		public bool isDead = false;
		public int post;
		public string name;
	}
	
	public static int day = 0;
	public static string deadToday;

	public static Character reibaishi;
	public static Character jinro;

	void Start(){
		//reibaishi.isDead = false;
	}

	void Update () {

	}

}
