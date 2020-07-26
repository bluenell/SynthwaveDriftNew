using UnityEngine;

public class GameManager : MonoBehaviour
{
	private bool _isAlive;
	private bool _isInWarmupStage;

	private float _timeAlive;

	[SerializeField] private CarCollider _carCollider;


	[Header("Game Settings")]
	[SerializeField] private int _warmupStageLength;

	public bool IsAlive => _isAlive;
	public bool IsInWarmupStage { get => _isInWarmupStage; set => _isInWarmupStage = value; }
	public int WarmupStageLength => _warmupStageLength;

	private void Awake()
	{
		_carCollider.Collided += EndCurrentGame;
	}

	private void Update()
	{
		_timeAlive += Time.deltaTime;		
	}

	void EndCurrentGame()
	{
		Debug.Log("End Game");
		_isAlive = false;
		SceneSwitcher.SwitchScene(1);
	}

	public float GetDistanceTravelled()
	{
		RoadMotor roadGenerator = FindObjectOfType<RoadMotor>();
		return roadGenerator.RoadSpeed * _timeAlive;
	}

}
