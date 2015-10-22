using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwitchScreen : MonoBehaviour {

	public Image screenFade;
	public float alpha;
	bool fading;
	bool canEnd = false;

	// Use this for initialization
	void Start () {
		Invoke ("Ending",3f);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(fading == true){
			screenFade.color = new Color(1,1,1,alpha);
			
			if (alpha < 1) {
				alpha += .5f * Time.deltaTime;
			} else {
				if(Application.loadedLevel == 1){
				Application.LoadLevel("Colors");
				}

				if(Application.loadedLevel == 2){
					Application.LoadLevel("Tears");
				}

				if(Application.loadedLevel == 3){
					Application.LoadLevel("Body");
				}
			}
		}

		if(Input.anyKeyDown && Application.loadedLevel == 1){
			fading = true;
		}

		if(Input.anyKeyDown && Application.loadedLevel == 8){
			if(canEnd){
			Application.Quit();
			}
		}
	
	}

	void Fading(){
		fading = true;
	}

	void Ending(){
		canEnd = true;
	}
	
}
