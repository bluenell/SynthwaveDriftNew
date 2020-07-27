using Boo.Lang;

public static class CarsDataContainer
{
	private static List<Car> _unlockedCars;
	public static List<Car> UnlockedCars => _unlockedCars;

	private static List<Car> _lockedCars;
	public static List<Car> LockedCars => _lockedCars;

	public static void UnlockCar(Car carToUnlock)
	{
		_lockedCars.Remove(carToUnlock);
		_unlockedCars.Add(carToUnlock);		
	}


}
