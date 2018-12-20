//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {

	public float distanceFromChain = 0.1f;

	public void ConnectEnd(Rigidbody2D endRB) {

		HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D> ();
		joint.autoConfigureConnectedAnchor = false;
		joint.connectedBody = endRB;
		joint.anchor = Vector2.zero;
		joint.connectedAnchor = new Vector2 (0.0f, -distanceFromChain);

	}
	

}
