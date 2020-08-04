using System.Collections.Generic;
using UnityEngine;

public class CarsDataContainer : MonoBehaviour
{
	public List<Car> PlayableCars;
	public List<Car> PurchasableCars;
	public List<Car> LockedCars;

	public List<Car> AllCars;

	private void Awake()
	{
		CheckCarUnlockStatus();
		CleanUp();
	}


	private void CheckCarUnlockStatus()
	{
		foreach (Car car in AllCars)
		{
			switch (car.CurrentUnlockState)
			{
				case Car.UnlockState.Playable:
					PopulateList(PlayableCars, car);
					break;

				case Car.UnlockState.Purchasable:
					PopulateList(PurchasableCars, car);
					break;

				case Car.UnlockState.Locked:
					PopulateList(LockedCars, car);
					break;

				default:
					break;
			}			
		}
	}

	private void PopulateList(List<Car> listToPopulate, Car carToPopulate)
	{
		listToPopulate.Add(carToPopulate);
	}


	private void CleanUp()
	{
		AllCars.Clear();
	}


}
