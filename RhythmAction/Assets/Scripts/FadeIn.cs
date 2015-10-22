using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public Image screenFade;

	// Use this for initialization
	void Start () {
	
	}
	

	void Update () {
		screenFade.CrossFadeAlpha(0f, 1.0f, false);

	}
}
