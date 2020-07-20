using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMotor : MonoBehaviour
{
	[SerializeField] float _movementSpeed;

	[SerializeField] CarCollider _carCollider;

	private void Awake()
	{
		_carCollider = FindObjectOfType<CarCollider>();
		_carCollider.Collided += StopMovement;
	}


	private void FixedUpdate()
	{
		transform.Translate(new Vector3(0, 0, -_movementSpeed * Time.deltaTime));
	}

	public void StopMovement()
	{
		_movementSpeed = 0;
	}

	private void OnDisable()
	{
		_carCollider.Collided -= StopMovement;

	}


}
