using UnityEngine;

public class GameManager : MonoBehaviour
{
	private bool _isAlive;
	[SerializeField] private CarCollider _carCollider;


	private void Awake()
	{
		_carCollider.Collided += EndCurrentGame;
	}

	public bool IsAlive 
	{
		get 
		{ 
			return _isAlive; 
		} 

	}

	void EndCurrentGame()
	{
		Debug.Log("End Game");
		_isAlive = false;
		SceneSwitcher.SwitchScene(1);
	}


}
