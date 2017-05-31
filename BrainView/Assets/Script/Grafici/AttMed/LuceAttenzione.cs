using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LuceAttenzione : MonoBehaviour {

	public DisplayData controller;

	private int attention;

	public Light luceAtt;

	void Start () {
		
	}


	void OnUpdateAttention(int value){
		attention = value;
	}
		
	void update(int valueAtt, int valueMed){
		//=controller.
		//valueAtt = 1 * attention / 100;
		//luceAtt.intensity = (float)valueAtt;
	}

}
