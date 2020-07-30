using TMPro;
using UnityEngine;

public class ShopUI : MonoBehaviour
{

	private CarSpawner _carSpawner;
	private GameInititaliser _gameInit;
	private CarsDataContainer _carData;

	[SerializeField] private TextMeshProUGUI _carNameText;

	[SerializeField] private TextMeshProUGUI _currentCassettes;
	[SerializeField] private TextMeshProUGUI _cassettesToBuy;



	private void Start()
	{
		_carNameText.text = _carSpawner.SelectedCar.CarName.ToUpper() ;
	}

	private void Awake()
	{
		_gameInit = FindObjectOfType<GameInititaliser>();
		_carSpawner = FindObjectOfType<CarSpawner>();
	}

	public void CycleRight()
	{
		_carSpawner.LoadNextCar();
		_carNameText.text = _carSpawner.SelectedCar.CarName.ToUpper();
	}

	public void CycleLeft()
	{
		_carSpawner.LoadPreviousCar();
		_carNameText.text = _carSpawner.SelectedCar.CarName.ToUpper();
	}

	public void PlayGame()
	{
		this.gameObject.SetActive(false);
		_gameInit.StartGame();			

	}

	private void Update()
	{
		_currentCassettes.text = PlayerStats.CurrentCassettes.ToString();
		_cassettesToBuy.text = _carSpawner.SelectedCar.CassettesNeededToPurchase.ToString();
	}

	public void BuyCar()
	{
		PlayerStats.SpendCassetes(_carSpawner.SelectedCar.CassettesNeededToPurchase);	


	}

}
