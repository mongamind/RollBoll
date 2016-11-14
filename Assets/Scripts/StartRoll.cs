using UnityEngine;
using System.Collections;

public class StartRoll : MonoBehaviour {

	void Update () {
		transform.Rotate (new Vector3 (45, 45, 45) * Time.deltaTime);
	}
}
