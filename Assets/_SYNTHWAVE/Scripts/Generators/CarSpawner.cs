using UnityEngine;
using System.Collections.Generic;

public class CarSpawner : MonoBehaviour
{
	[SerializeField] private List<GameObject> _cars;	
	[SerializeField] private GameObject _carParent;

	private int _carIndex;

	private void Awake()
	{
		SpawnCar(Random.Range(0, _cars.Count));
	}

	private void SpawnCar(int index)
	{
		GameObject currentCar;
		currentCar = Instantiate(_cars[index]);

		currentCar.transform.SetParent(_carParent.transform);
		currentCar.transform.localPosition = Vector3.zero;

	}

}
