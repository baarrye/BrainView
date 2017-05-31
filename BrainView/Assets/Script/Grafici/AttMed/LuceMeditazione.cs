using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LuceMeditazione : MonoBehaviour {

	TGCConnectionController controller;

	private int meditation;

	public Light luceMed;

	void Start () {
		controller = GameObject.Find("NeuroSkyTGCController").GetComponent<TGCConnectionController>();
		controller.UpdateMeditationEvent += OnUpdateMeditation;
	}



	void OnUpdateMeditation(int value){
		meditation = value;
	}

	void update(int valueMed){
		valueMed = 1 * meditation / 100;

		luceMed.intensity = (float)valueMed;
	}

}
