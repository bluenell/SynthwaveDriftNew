using System;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
	[SerializeField] GameObject[] _obstacleGroups;
	private RoadGenerator _roadGenerator;
		
	private void Awake()
	{
		_roadGenerator = FindObjectOfType<RoadGenerator>();

		if (_roadGenerator.GenerateWithObstacles)
		{
			GameObject obstacleGroup = Instantiate(_obstacleGroups[UnityEngine.Random.Range(0, _obstacleGroups.Length)]);
			obstacleGroup.transform.parent = this.transform;
			obstacleGroup.transform.localPosition = new Vector3(0, 0.5f, 16);
		}

		
	}
	
}
