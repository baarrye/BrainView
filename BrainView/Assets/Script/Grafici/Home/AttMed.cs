using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttMed : MonoBehaviour {

	TGCConnectionController controller;

	private int attention;
	private int meditation;

	public GameObject circleAtt;
	public GameObject circleMed;

	void Start () {
		controller = GameObject.Find("NeuroSkyTGCController").GetComponent<TGCConnectionController>();
		controller.UpdateAttentionEvent += OnUpdateAttention;
		controller.UpdateMeditationEvent += OnUpdateMeditation;
	}


	void OnUpdateAttention(int value){
		attention = value;
	}

	void OnUpdateMeditation(int value){
		meditation = value;
	}

	void update(int valueAtt, int valueMed){
		valueAtt = 1 * attention / 100;
		valueMed = 1 * meditation / 100;
		circleAtt.transform.localScale=new Vector3(valueAtt, valueAtt, 1);
		circleMed.transform.localScale=new Vector3(valueMed, valueMed, 1);
	}

}
