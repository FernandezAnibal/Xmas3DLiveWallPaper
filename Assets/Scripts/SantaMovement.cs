using UnityEngine;
using System.Collections;

public class SantaMovement : MonoBehaviour {

	private Vector3 iniPos;
	private bool permit = true;
	private int selector;

	public Rigidbody[] regalos;

	private Rigidbody regaloInstance;
	// Use this for initialization
	void Start () {
		iniPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (System.DateTime.Now.Second == 30){
			permit = true;
		}

		if (permit == true) {
			transform.Translate (Vector3.forward * Time.deltaTime * 2);
		}

		if (transform.position.x > 30) {
			transform.position = iniPos;
			permit = false;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Casa" && permit) {
				selector = Mathf.FloorToInt (Random.Range (0f, 6.9f));
				regaloInstance = Instantiate (regalos [selector], transform.position, transform.rotation) as Rigidbody;
				regaloInstance.AddForce (Vector3.up * 400);
				regaloInstance.AddForce (Vector3.left * 200);
			regaloInstance.AddTorque(new Vector3 (Random.Range (0, 40),Random.Range (0, 40),Random.Range (0, 40)));
			}
	}
}
