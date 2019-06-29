using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class clubExpanseMusic : MonoBehaviour {
	int onSongNo = 0;
	int numOfSongs = 0;

	Text urlInputField;
	string urlInput;
	string tempLastSong;
	string[] songURL;
	bool paused = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pausePlay(){
		if (!paused) {
			paused = true;
			//player.Pause();
		}else{
			paused = false;
			//player.Play();
		}
	}

	public void playNextSong(){
		//player.URL = songURL[1];
		//tempLastSong = song[1];
		//player.Play();
		//remove first in songURLList;
	}

	public void addToQueue(){
		numOfSongs++;
		urlInput =	urlInputField.ToString ();
		urlInputField.text = "";
		//add urlInput to last in list;
	}
}
