using UnityEngine;
using System.Collections;

public class BeatsChecker : MonoBehaviour {


	public float BPM = 158f;
	public float beatSamples;
	public float nextBeatSamples;
	public AudioSource note;
	AudioSource song;



	void Start () {

		song = GetComponent<AudioSource>();
		beatSamples = (44100 / (BPM / 60));
	}
	

	void Update () {
		if (song.timeSamples >= nextBeatSamples && song.isPlaying) {
			note.Play();

			nextBeatSamples += beatSamples;

	
	}
}
}
