using UnityEngine;

public class GameManager : MonoBehaviour
{
	private bool _isAlive;
	private bool _isInWarmupStage;

	[SerializeField] private CarCollider _carCollider;
	[SerializeField] private int _warmupStageLength;

	public bool IsAlive => _isAlive;
	public bool IsInWarmupStage { get => _isInWarmupStage; set => _isInWarmupStage = value; }
	[HideInInspector] public int WarmupStageLength => _warmupStageLength;

	private void Awake()
	{
		_carCollider.Collided += EndCurrentGame;
	}

	void EndCurrentGame()
	{
		Debug.Log("End Game");
		_isAlive = false;
		SceneSwitcher.SwitchScene(1);
	}


}
