using UnityEngine;

public class GameManager : MonoBehaviour
{
	private bool _isAlive;
	private bool _isInWarmupStage;

	private float _timeAlive;
	private int _cassettesPerRun;

	public int CassettesPerRun { get => _cassettesPerRun;  set => _cassettesPerRun = value; }


	public int CurrentCassettes => (int)_cassettesPerRun;


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

	}

	void Start()
	{
		_playerStatsManager.PlayerStats.TotalCassettes = PlayerPrefs.GetInt(PlayerPrefKeys.TotalCassettes);
	}

	private void Update()
	{
		if (!_isInShop)
		{
			_timeAlive += Time.deltaTime;
		}		
	}



	public void EndCurrentGame()
	{
		Debug.Log("End Game");
		_playerStatsManager. PlayerStats.IncreaseCassettes(_cassettesPerRun);
		_playerStatsManager.WriteToPlayerPrefs(PlayerPrefKeys.TotalCassettes, _playerStatsManager.PlayerStats.TotalCassettes);


		_isAlive = false;
		SceneSwitcher.SwitchScene(0);
	}

	public float GetDistanceTravelled()
	{
		RoadMotor roadGenerator = FindObjectOfType<RoadMotor>();
		return roadGenerator.RoadSpeed * _timeAlive;
	}
}