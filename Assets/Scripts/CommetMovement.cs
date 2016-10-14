using UnityEngine;
using System.Collections;


[System.Serializable]
public abstract class CommetMovement
{
	public abstract void move (Transform t);
	// since it is abstract, we do not implement

}

/*
public class Mover : MonoBehaviour {
	public float speed;

	void Start ()
	{
		Rigidbody rb = GetComponent<Rigidbody>();		
		rb.velocity = transform.forward * speed;
	}
}
*/