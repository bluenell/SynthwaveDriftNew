using UnityEngine;
using System.Collections.Generic;

public class CarSpawner : MonoBehaviour
{
	
	[SerializeField] private GameObject _carParent;

	private int _carIndex = 0;
	private CarsDataContainer _carsDataContainer;
	private Car _selectedCar;

	[SerializeField] private List<Car> _carsInShop;

	public Car SelectedCar => _selectedCar;


	private void Awake()
	{
		_carsDataContainer = FindObjectOfType<CarsDataContainer>();
	}

	private void Start()
	{
		foreach (Car car in _carsDataContainer.PlayableCars)
		{
			_carsInShop.Add(car);
		}

		foreach (Car car in _carsDataContainer.PurchasableCars)
		{
			_carsInShop.Add(car);
		}

		foreach (Car car in _carsDataContainer.LockedCars)
		{
			_carsInShop.Add(car);
		}

		_selectedCar = _carsInShop[_carIndex];
		SpawnCar();
	}

	private void SpawnCar()
	{
		GameObject currentCar;
		currentCar = Instantiate(_selectedCar.CarGameObject);

		currentCar.transform.SetParent(_carParent.transform);
		currentCar.transform.localPosition = Vector3.zero;
	}

	public void LoadNextCar()
	{
		Destroy(_carParent.transform.GetChild(1).gameObject);

		_carIndex++;

		if (_carIndex > _carsInShop.Count - 1)
		{
			_carIndex = 0;
		}

		_selectedCar = _carsInShop[_carIndex];
		SpawnCar();
	}

	public void LoadPreviousCar()
	{
		Destroy(_carParent.transform.GetChild(1).gameObject);

		_carIndex--;

		if (_carIndex < 0)
		{
			_carIndex = _carsInShop.Count - 1;
		}
		_selectedCar = _carsInShop[_carIndex];

		SpawnCar();
	}



}
