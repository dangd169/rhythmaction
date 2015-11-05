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
	
	}
	
	// Update is called once per frame
	void Update () {
		if(fading == true){
			screenFade.color = new Color(1,1,1,alpha);
			
			if (alpha < 1) {
				alpha += .5f * Time.deltaTime;
			} else { 
				if(Application.loadedLevel == 1){
				Application.LoadLevel("End");
				}

				if(Application.loadedLevel == 0){
					Application.LoadLevel("Song Level");
				}


			}
		}

		if(Input.anyKeyDown && Application.loadedLevel == 0){
			fading = true;
		}

		if(Input.anyKeyDown && Application.loadedLevel == 2){
			if(canEnd){
			fading = true;
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
