using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMotor : MonoBehaviour
{
	[SerializeField] float movementSpeed;

	private void Update()
	{
		transform.Translate(new Vector3(0, 0, -movementSpeed * Time.deltaTime));
	}

}
