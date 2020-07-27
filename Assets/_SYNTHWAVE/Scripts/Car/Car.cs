using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/Car")]
public class Car : ScriptableObject
{
	[Header("Car Info")]
	public string _name;
	public int _id;
	public GameObject _carGameObject;

	[Header("Purchasing Info")]
	int _cassettesNeededToPurchase;
	bool _carUnlocked;
	bool _carPurchased;

	public int CassettesNeededToPurchase => _cassettesNeededToPurchase;
	public bool IsCarUnlocked => _carUnlocked;
	public bool IsCarPurchased => _carPurchased;

	public void PurchaseCar()
	{
		_carPurchased = true;
		PlayerStats.SpendCassetes(_cassettesNeededToPurchase);
		CarsDataContainer.UnlockCar(this);
	}


}
