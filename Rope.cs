//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour {

	public Rigidbody2D hook;
	public GameObject linkPrefab;
	public int links = 8;
	public Weight weight;
	public Rigidbody2D lastRB;





	void Start () {

		GenerateRope ();
		//GenerateNewLink ();
	}


	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			GenerateLink();
//			Vector2 destiny = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//			Transform destiny2 = Vector2.MoveTowards (transform.position,destiny,5);
		}
	}


	
	void GenerateRope(){

		Rigidbody2D previousRB = hook;
		for (int i = 0; i < links; i++)
		{
			GameObject link = Instantiate(linkPrefab, transform);
			HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
			Rigidbody2D RB = link.GetComponent<Rigidbody2D> ();
			Transform Tf = link.GetComponent<Transform> ();

			joint.connectedBody = previousRB;
			previousRB = RB;
			}

		lastRB =previousRB;
		weight.ConnectEnd (lastRB);

	
	}



void GenerateLink(){


		GameObject link2 =Instantiate(linkPrefab,transform);
			HingeJoint2D joint2 = link2.GetComponent<HingeJoint2D>();
			Rigidbody2D RB2= link2.GetComponent<Rigidbody2D> ();

			joint2.connectedBody = lastRB;
			lastRB = RB2;

		}


}