using System;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
	[SerializeField] GameObject[] _obstacleGroups;
		
	private void Awake()
	{		
		GameObject obstacleGroup = Instantiate(_obstacleGroups[UnityEngine.Random.Range(0,_obstacleGroups.Length)]);
		obstacleGroup.transform.parent = this.transform;
		obstacleGroup.transform.localPosition = new Vector3(0,0,16);
	}
	
}
