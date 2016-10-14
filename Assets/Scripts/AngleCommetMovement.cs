using UnityEngine;
using System.Collections;

[System.Serializable]
public class AngleCommetMovement : CommetMovement 
{
	public float xChange;
	public float yChange; 
	public float rand1, rand2;

	/*void Start()
	{
		rand1 = UnityEngine.Random.Range(-100,100);
		rand2 = UnityEngine.Random.Range(-10,10);
	}*/


	public override void move(Transform t)
	{
		//Vector3 e = t.eulerAngles;
		//e.x += rand1;
		//t.eulerAngles = e;

		Vector3 v = t.position;
		Vector3 origin = Vector3.zero;

		xChange = v.x - origin.x;

		v.x -= xChange * 0.025f;

		yChange = v.y - origin.y;

		v.y -= yChange * 0.025f;

		t.position = v;


	}
}