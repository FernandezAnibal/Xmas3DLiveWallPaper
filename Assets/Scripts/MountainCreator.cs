using UnityEngine;
using System.Collections;

public class MountainCreator : MonoBehaviour {

	private bool permit=false;
	public GameObject mountain;
	private GameObject mountainInstance;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (permit){
			mountainInstance= Instantiate(mountain, new Vector3(transform.position.x - Random.Range(11f,15f), transform.position.y - Random.Range(0,1f), transform.position.z), transform.rotation) as GameObject;
			permit = false;
		}


	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == mountain.gameObject.tag){
			permit = false;
			
		}
	}
	
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == mountain.gameObject.tag){
			permit = true;
		}
	}
}
