using UnityEngine;
using System.Collections.Generic;

public class CarSpawner : MonoBehaviour
{
	[SerializeField] private List<GameObject> _cars;
	[SerializeField] private int _carIndex;
	[SerializeField] private GameObject _carParent;

	private void Awake()
	{
		SpawnCar();
	}

	private void SpawnCar()
	{
		GameObject currentCar;
		currentCar = Instantiate(_cars[_carIndex]);

		currentCar.transform.SetParent(_carParent.transform);
		currentCar.transform.localPosition = Vector3.zero;

	}

}
