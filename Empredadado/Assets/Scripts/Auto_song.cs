using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_song : MonoBehaviour {

	GameObject song;
	AudioSource sond; 
	public AudioClip music;

	void Start(){
		song = this.gameObject;
		song.AddComponent<AudioSource>();
		sond = GetComponent<AudioSource>();
		sond.playOnAwake = false;
		sond.clip = music;
	}

	public void playerd(){
		sond.Play();	
	}

}
