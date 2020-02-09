using UnityEngine;
using System.Collections;

public class ManagerPaper : MonoBehaviour {

	public ParticleSystem Snow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetSnow(string opsnow){

		if(opsnow == "yes") {
			Snow.Play();
		}else{
			Snow.Stop();
			Snow.Clear();
		}
	}
}
