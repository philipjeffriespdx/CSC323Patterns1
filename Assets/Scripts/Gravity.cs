using UnityEngine;
using System.Collections;

[System.Serializable]
public class Gravity : MonoBehaviour 
{
	/*
	public ArrayList observers = new ArrayList();
	public GameObject go;

	void FixedUpdate()
	{
		foreach (object o in observers)
		{
			if (o != null) 
			{
				go = (GameObject)o;
				Vector3 diff = go.transform.position - transform.position;
				diff.Normalize ();
				go.transform.position -= diff * .02f;
			}
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		observers.Add (other.gameObject);
	} 
	*/
}
