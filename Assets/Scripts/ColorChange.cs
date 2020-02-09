using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

	public Color [] colorCasa = new Color[5];
	// Use this for initialization
	void Start () {
			
	
	}

	void Awake(){
		for (int i = 0; i < gameObject.GetComponent<Renderer> ().materials.Length; i++) {
	
			if (gameObject.GetComponent<Renderer> ().materials [i].color == new Color(0,0,0,1) ){
				gameObject.GetComponent<Renderer> ().materials [i].color = colorCasa[Mathf.FloorToInt(Random.Range(0f,4.99f))];
			} 
		}
	

	}


	// Update is called once per frame
	void Update () {

	}
}
