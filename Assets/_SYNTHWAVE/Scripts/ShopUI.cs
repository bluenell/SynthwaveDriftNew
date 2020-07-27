using TMPro;
using UnityEngine;

public class ShopUI : MonoBehaviour
{

	private CarSpawner _carSpawner;
	private GameInititaliser _gameInit;
	[SerializeField] private TextMeshProUGUI _carNameText;

	private void Start()
	{
		
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
}
