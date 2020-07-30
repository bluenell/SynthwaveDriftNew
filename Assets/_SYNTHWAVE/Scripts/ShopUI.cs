using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{

	private CarSpawner _carSpawner;
	private GameInititaliser _gameInit;
	private PlayerStatsManager _playerStatsManager;
	
	[SerializeField] private TextMeshProUGUI _carNameText;

	[SerializeField] private TextMeshProUGUI _currentCassettes;
	[SerializeField] private TextMeshProUGUI _cassettesToBuy;


	[SerializeField] private GameObject _buyButton;
	[SerializeField] private GameObject _playButton;
	[SerializeField] private GameObject _lockedText;



	private void Start()
	{
		
	}

	private void Awake()
	{
		_gameInit = FindObjectOfType<GameInititaliser>();
		_carSpawner = FindObjectOfType<CarSpawner>();
		_playerStatsManager = FindObjectOfType<PlayerStatsManager>();
	}

	private void Update()
	{
		_currentCassettes.text = _playerStatsManager.PlayerStats.TotalCassettes.ToString();
		_carNameText.text = _carSpawner.SelectedCar.CarName.ToUpper();
		_cassettesToBuy.text = _carSpawner.SelectedCar.CassettesNeededToPurchase.ToString();
		CheckCarUnlockStatus();

	}

	private void CheckCarUnlockStatus()
	{
		switch (_carSpawner.SelectedCar.CurrentUnlockState)
		{
			case Car.UnlockState.Playable:
				_playButton.SetActive(true);
				_buyButton.SetActive(false);
				_lockedText.SetActive(false);
				break;

			case Car.UnlockState.Purchasable:
				_playButton.SetActive(false);
				_buyButton.SetActive(true);
				_lockedText.SetActive(false);
				break;

			case Car.UnlockState.Locked:
				_buyButton.SetActive(false);
				_playButton.SetActive(false);
				_lockedText.SetActive(true);

				break;
			default:
				break;
		}
	}

	public void CycleRight()
	{
		_carSpawner.LoadNextCar();
	}

	public void CycleLeft()
	{
		_carSpawner.LoadPreviousCar();
	}

	public void PlayGame()
	{
		this.gameObject.SetActive(false);
		_gameInit.StartGame();			

	}

	public void BuyCar()
	{
		int cassetesToBuy = _carSpawner.SelectedCar.CassettesNeededToPurchase;
		int totalCassetes = _playerStatsManager.PlayerStats.TotalCassettes;
		
		if (cassetesToBuy <= totalCassetes)
		{
			_playerStatsManager.PlayerStats.SpendCassetes(cassetesToBuy);
			_carSpawner.SelectedCar.PurchaseCar();
			CheckCarUnlockStatus();
		}
		


	}

}
