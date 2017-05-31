using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class Radar_Controller : MonoBehaviour {

	public DisplayData disp;
	public UIPolygon radar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			radar.VerticesDistances [1] = disp.HighBeta;
			radar.VerticesDistances [2] = disp.LowBeta;
			radar.VerticesDistances [3] = disp.HighAlpha;
			radar.VerticesDistances [4] = disp.LowAlpha;
			radar.VerticesDistances [5] = disp.Theta;
			radar.VerticesDistances [6] = disp.Delta;
			radar.VerticesDistances [7] = disp.HighGamma;
			radar.VerticesDistances [8] = disp.LowGamma;
			radar.VerticesDistances [0] = disp.LowGamma;

	}
}
