using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMoviment : MonoBehaviour {

	void Update () {
		transform.Rotate (new Vector3 (0.0f,70.0f,0.0f) * Time.deltaTime);
	}
}
