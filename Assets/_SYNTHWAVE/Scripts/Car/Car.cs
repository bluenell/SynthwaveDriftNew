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
	
	public enum UnlockState
	{
		Playable,
		Purchasable,
		Locked
	};

	public UnlockState CurrentUnlockState;

	public int CassettesNeededToPurchase => _cassettesNeededToPurchase;

	public void PurchaseCar()
	{
		CurrentUnlockState = UnlockState.Playable;
	}

	public void UnlockCar()
	{
		CurrentUnlockState = UnlockState.Purchasable;
	}


}
