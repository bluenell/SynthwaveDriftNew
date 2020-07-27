using System.Collections.Generic;
using UnityEngine;

public  class CarsDataContainer : MonoBehaviour
{
	public List<Car> UnlockedCars;
	public List<Car> LockedCars;

	public void UnlockCar(Car carToUnlock)
	{
		UnlockedCars.Add(carToUnlock);
		LockedCars.Remove(carToUnlock);
		
	}


}
