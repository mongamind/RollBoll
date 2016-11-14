using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Camera cm;
	public float speed;
	public Text countText;

	private Rigidbody rb;
	private Vector3 offset;
	private int count;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		offset = cm.transform.position - transform.position;
		count = 0;
	}
	
	void FixedUpdate () {
		float fHorAxis = Input.GetAxis ("Horizontal");
		float fVerAxis = Input.GetAxis ("Vertical");
		Vector3 force = new Vector3 (fHorAxis, 0, fVerAxis);
		force = force * speed;
		rb.AddForce (force);
	}

	void LateUpdate()
	{
		cm.transform.position = transform.position + offset;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Start")) {
			other.gameObject.SetActive (false);
			count++;
			setCountText ();
		}
	}

	void setCountText()
	{
		countText.text = "Count: " + count;
	}
}
