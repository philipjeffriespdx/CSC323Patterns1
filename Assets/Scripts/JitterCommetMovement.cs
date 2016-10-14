using UnityEngine;
using System.Collections;

[System.Serializable]
public class JitterCommetMovement : CommetMovement
{
	public override void move(Transform t)
	{
		//move forward
		//t.position = t.position - t.forward * 0.1f;
		float temp = UnityEngine.Random.Range(-0.05f,0.05f);
		Vector3 v = t.position;
		v.x += temp;
		v.z -= 0.01f;
		t.position = v;

		//this is for rotation
		/*
		Vector3 v = t.rotation.eulerAngles;
		v.y += 5;
		t.rotation = Quaternion.Euler(v);
		*/
	}
}
