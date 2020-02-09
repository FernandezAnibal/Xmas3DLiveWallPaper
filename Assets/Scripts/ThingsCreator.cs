using UnityEngine;
using System.Collections;

public class ThingsCreator : MonoBehaviour {

	private bool permit=false;
	public GameObject thing;
	private GameObject thingInstance;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (permit){
			thingInstance= Instantiate(thing, transform.position, transform.rotation) as GameObject;
				permit = false;
		}
		
		
	}
	
	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == thing.gameObject.tag) {
			permit = false;
		}


	}
	
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == thing.gameObject.tag) {
			permit = true;
		}
	}
}

