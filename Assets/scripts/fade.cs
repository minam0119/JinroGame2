using UnityEngine;
using System.Collections;

public class fade : MonoBehaviour {

	private bool  _play;
    private bool _fadeIn;
    private float time;
    
    // Use this for initialization
    void Start () {
    
        _play = false;
        _fadeIn = false;
        time = 0;
    }
    // Update is called once per frame
    void Update () {
    
        if(_play){
 
            time += Time.deltaTime;
            if(_fadeIn){
 
                GetComponent<GUITexture>().color =new Color(1,1,1,Mathf.Lerp(1,0,time) );
 
            }else{
 
                GetComponent<GUITexture>().color = new Color(1,1,1,Mathf.Lerp(0,1,time));
 
            }
 
 
            if(time >= 1){
 
                _play = false;
 
            }
 
        }
 
    }
 
    public void startFadeIn(){
 
        _play = true;
        _fadeIn = true;
        time = 0;
 
    }
 
    public void startFadeOut(){
        
        _play = true;
        _fadeIn = false;
        time = 0;
        
    }
}
