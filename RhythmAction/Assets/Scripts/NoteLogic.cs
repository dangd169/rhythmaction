using UnityEngine;
using System.Collections;

public class NoteLogic : MonoBehaviour {

	// Use this for initialization

	bool click = false;
	public SpriteRenderer red;
	public SpriteRenderer yellow;
	public SpriteRenderer blue;
	public SpriteRenderer brown;

	int spriteColor;
	
	float angle = 360.0f; 
	float angle2 = 80.0f; 
	float time = 1.0f; 
	bool spinning;
	bool falling;
	float offset = 10;

	public static float score;

	public ParticleSystem left;
	public ParticleSystem right;


	void Start () {
		score = 0;
		spriteColor = Random.Range(1,5);
		offset = Random.Range(-.15f,.15f);
		Vector3 temp = new Vector3(offset,0,0);
		transform.position += temp;
	}
	
	// Update is called once per frame
	void Update () {


		if(spriteColor == 1){
			red.enabled=true;
		}
		if(spriteColor == 2){
			yellow.enabled=true;
		}
		if(spriteColor == 3){
			blue.enabled=true;
		}
		if(spriteColor == 4){
			brown.enabled=true;
		}

		if(spinning){
			transform.RotateAround(transform.position, Vector3.up, angle * Time.deltaTime / time);
		}

		if(falling){
			transform.RotateAround(transform.position, Vector3.left, angle2 * Time.deltaTime / time);
		}


		if(click){
			if(Input.GetMouseButtonDown(1) && this.gameObject.CompareTag ("RightNote")){
				spinning = true;
				Invoke ("Destroy",.75f);
				right.Emit(20);

			


			}
			if(Input.GetMouseButtonDown(0) && this.gameObject.CompareTag ("LeftNote")){
				spinning = true;
				Invoke ("Destroy",.75f);
				left.Emit(20);




			}
		}
	
	}

	void Clickable () {
		click = true;
	}

	void NotClickable () {
		click = false;
		falling = true;
		Invoke("Destroy", 2);
	}

	void Destroy(){
		Destroy(gameObject);
	}
}
