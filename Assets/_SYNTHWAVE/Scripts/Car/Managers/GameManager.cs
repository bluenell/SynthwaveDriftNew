using UnityEngine;

public class GameManager : MonoBehaviour
{
	private bool _isAlive;
	private bool _isInWarmupStage;

	private float _timeAlive;
	private float _cassettesPerRun;

	public int CurrentCassettes => (int)_cassettesPerRun;

	[SerializeField] private CarCollider _carCollider;

	CameraHandler _cameraHandler;
	PlayerStatsManager _playerStatsManager;

	[Header("Game Settings")]
	[SerializeField] [Range(0, 10)] private int _warmupStageLength;

	public bool IsAlive => _isAlive;
	public bool IsInWarmupStage { get => _isInWarmupStage; set => _isInWarmupStage = value; }
	public int WarmupStageLength => _warmupStageLength;

	private bool _isInShop;
	public bool IsInShop { get => _isInShop; set => _isInShop = value; }

	private void Awake()
	{
		_cameraHandler = FindObjectOfType<CameraHandler>();
		_playerStatsManager = FindObjectOfType<PlayerStatsManager>();
		_carCollider.Collided += EndCurrentGame;
	}

	private void Update()
	{
		if (!_isInShop)
		{
			_timeAlive += Time.deltaTime;
			_cassettesPerRun += Time.deltaTime;
		}		
	}



	void EndCurrentGame()
	{
		Debug.Log("End Game");

		_playerStatsManager. PlayerStats.IncreaseCassettes((int)_cassettesPerRun);

		_isAlive = false;
		SceneSwitcher.SwitchScene(0);

		

	}

	public float GetDistanceTravelled()
	{
		RoadMotor roadGenerator = FindObjectOfType<RoadMotor>();
		return roadGenerator.RoadSpeed * _timeAlive;
	}
}