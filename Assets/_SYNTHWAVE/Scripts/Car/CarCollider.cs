﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollider : MonoBehaviour
{

	//[SerializeField] float _raycastOffset = 5;


	public delegate void CollisionDetector();
	public event CollisionDetector Collided;


	private void Update()
	{
		/*
		Ray ray = new Ray(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + _raycastOffset));
		RaycastHit hit;

		Debug.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + _raycastOffset), Color.red);

		if (Physics.Raycast(ray, out hit))
		{
			Obstacle obstacle = hit.collider.gameObject.GetComponent<Obstacle>();

			if (obstacle != null)
			{
				Debug.Log("Hit " + hit.collider.gameObject.name) ;
				Collided.Invoke();		
			}

		}
		*/

	}

	private void OnCollisionEnter(Collision collision)
	{
		Obstacle obstacle = collision.gameObject.GetComponent<Obstacle>();

		if (obstacle != null)
		{
			Debug.Log("Hit");
			Collided.Invoke();
		}
	}
}
			