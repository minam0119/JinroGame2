using UnityEngine;
using System.Collections;

public class MainTimer : MonoBehaviour {

	//タイム 15分
	float time = 900f;
	Animator animator;

	//再度表示されないようにするbool
	bool remind15 = false;
	bool remind10 = false;
	bool remind5 = false;
	bool remind3 = false;
	bool remind1 = false;

	bool visible15 = false;
	bool visible10 = false;
	bool visible5 = false;
	bool visible3 = false;
	bool visible1 = false;

	float up_position = 50;


	//timerObjectの宣言
	public GameObject timer_15,timer_10,timer_5,timer_3,timer_1;

	// Use this for initialization
	void Start () {
		//print(timer_15.transform.position);
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		time -= Time.deltaTime;
		
		//15分

		if(time <= 900 && !remind15){
			remind15 = true;
			timer_15.SetActive(true);
			visible15 = true;
			print(remind15);
		}else{
			visible15 = false;
		}

		
		//10分
		if(time <= 890 && !remind10 && !visible15){
			remind10 = true;
			timer_10.SetActive(true);
			visible10 = true;

		}else if(time <= 890 && visible15 && !remind10){
			remind10 = true;
			timer_10.SetActive(true);
			timer_10.transform.position = new Vector3(511.6f,timer_15.transform.position.y + up_position,0f);

		}else{
			remind10 = true;
			visible10 = false;
		}

		/*--メモ--*/
		//UIの調整
		//時間を設定すると位置が重なる
		//remind10が機能していない

		//5分
		if(time <= 300 && !remind5 && !visible10){
			remind5 = true;
			timer_5.SetActive(true);
			visible5 = true;

		}else if(visible5 && !remind5){
			timer_5.SetActive(true);
			timer_5.transform.position = new Vector3(511.6f,timer_10.transform.position.y + up_position,0f);

		}else{
			visible5 = false;
		}

		//3分
		if(time <= 180 && !remind3 && !visible5){
			remind3 = true;
			timer_3.SetActive(true);
			visible3 = true;

		}else if(visible3 && !remind3){
			timer_3.SetActive(true);
			timer_3.transform.position = new Vector3(511.6f,timer_5.transform.position.y + up_position,0f);

		}else{
			visible3 = false;
		}

		//1分
		if(time <= 60 && !remind1 && !visible3){
			remind1 = true;
			timer_1.SetActive(true);
			visible1 = true;

		}else if(visible1 && !remind1){
			timer_1.SetActive(true);
			timer_1.transform.position = new Vector3(511.6f,timer_3.transform.position.y + up_position,0f);

		}else{
			visible1 = false;
		}

		//強制スキップ
		if(time <= 0){
			//黒くフェードインのアニメーション
			Application.LoadLevel("mainscene");
		}
	}

	//cancel_15分
	public void DestroyTimer15(){
		//timer_15.SetActive(false);
		animator.SetBool("bool15",true);
	}

	//cancel_10分
	public void DestroyTimer10(){
		//timer_10.SetActive(false);
		animator.SetBool("bool10",true);
	}

	//cancel_5分
	public void DestroyTimer5(){
		//timer_5.SetActive(false);
		animator.SetBool("bool5",true);
	}

	//cancel_3分
	public void DestroyTimer3(){
		//timer_3.SetActive(false);
		animator.SetBool("bool3",true);
	}

	//cancel_1分
	public void DestroyTimer1(){
		//timer_1.SetActive(false);
		animator.SetBool("bool1",true);
	}
}
