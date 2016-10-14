using UnityEngine;
using System.Collections;

[System.Serializable]
public class ForwardCommetMovement : CommetMovement
{
	public override void move(Transform t)
	{
		t.position = t.position - t.forward * 0.1f;
	}
}