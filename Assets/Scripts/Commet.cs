using UnityEngine;
using System.Collections;

[System.Serializable]
public class Commet : MonoBehaviour
{
	//depending on where we are (gravity or not) apply different movement

	public bool gravity = false;

	public CommetMovement commetMove = new ForwardCommetMovement();
	public CommetMovement commetJitter = new JitterCommetMovement();
	public CommetMovement commetAngle = new AngleCommetMovement();


	void FixedUpdate ()
	{
		commetMove.move(transform);
		commetJitter.move(transform);
		//commetAngle.move(transform);



		if (gravity) 
		{
			commetAngle.move (transform);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Gravity") 
		{
			gravity = true;

			// add to observers arraylist


		}
	} 
}

