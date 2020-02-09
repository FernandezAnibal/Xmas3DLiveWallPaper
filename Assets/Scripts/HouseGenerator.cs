using UnityEngine;
using System.Collections;

public class HouseGenerator : MonoBehaviour {


	// Use this for initialization
	public GameObject [] houses;
	public GameObject poste;
	public GameObject arbol;
	public GameObject snowman;


	private GameObject houseInstance;
	private GameObject posteInstance;
	private GameObject arbolInstance;
	private GameObject snowmanInstance;
	private bool permit = false;
	private int selector;


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (permit){
			permit = false;
			selector = Mathf.FloorToInt(Random.Range(0f,5.5f));
			houseInstance = Instantiate(houses[selector], transform.position, transform.rotation) as GameObject;
			posteInstance = Instantiate(poste,new Vector3(transform.position.x-6.5f,transform.position.y,transform.position.z),transform.rotation) as GameObject;

			if (Random.value < 0.5f){
				arbolInstance = Instantiate(arbol,new Vector3(transform.position.x-6f,transform.position.y,transform.position.z),transform.rotation) as GameObject;
			}else{
				snowmanInstance = Instantiate(snowman,new Vector3(transform.position.x-6f,transform.position.y,transform.position.z),transform.rotation) as GameObject;
			}
		}

	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Casa"){
			permit = false;
			
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Casa"){
			permit = true;
	
		}
	}

	
}

