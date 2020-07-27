using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/Car")]
public class Car : ScriptableObject
{
	[Header("Car Info")]
	public string CarName;
	public int Id;
	public GameObject CarGameObject;

	[Header("Purchasing Info")]
	[SerializeField] int _cassettesNeededToPurchase;
	[SerializeField] bool _carUnlocked;
	[SerializeField] bool _carPurchased;

	public int CassettesNeededToPurchase => _cassettesNeededToPurchase;
	public bool IsCarUnlocked => _carUnlocked;
	public bool IsCarPurchased => _carPurchased;

	public void PurchaseCar()
	{
		_carPurchased = true;
		PlayerStats.SpendCassetes(_cassettesNeededToPurchase);
	}

	public void UnlockCar()
	{
		_carUnlocked = true;
	}


}
