using UnityEngine;
using System.Collections;

[System.Serializable]
public class Factory : MonoBehaviour
{
	/*
	public GameObject tomake;
	public float rand1, rand2, rand3;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		rand1 = UnityEngine.Random.Range(-12f,12f);
		rand2 = UnityEngine.Random.Range(-12f,12f);

		Vector3 v = new Vector3(rand1, rand2, 15f);

		Object o = Instantiate(tomake, v, Quaternion.identity);
		GameObject go = (GameObject)o;
		Commet C = go.GetComponent<Commet>();

		rand3 = 3; //UnityEngine.Random.Range(1,3);

		if (rand3 == 1)
			C.commetMove = new ForwardCommetMovement ();
		else if (rand3 == 2)
			C.commetMove = new JitterCommetMovement ();
		else if (rand3 == 3)
			C.commetMove = new AngleCommetMovement ();
	}
	*/

	public GameObject tomake;
	public float rand1, rand2;

	void Start()
	{
		InvokeRepeating("MakeCommet", 2.0f, 0.1f);
	}

	void MakeCommet()
	{
		//set where objects are made
		rand1 = UnityEngine.Random.Range(-4f,4f);
		rand2 = UnityEngine.Random.Range(-4f,4f);

		Vector3 v = new Vector3(rand1, rand2, 15f);

		Instantiate(tomake, v, Quaternion.identity);
	}
}
