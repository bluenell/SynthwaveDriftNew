using UnityEngine;

public class CassetteSpawner : MonoBehaviour
{
	[SerializeField] private GameObject _cassettePrefab;

	[SerializeField] private int _cassetteSpacing;
	[SerializeField] private int _maxCassettesPerRoad;

	private void Awake()
	{
		SpawnCassette();
	}

	private void SpawnCassette()
	{
		for (int i = 0; i < _maxCassettesPerRoad; i++)
		{
			GameObject cassette = Instantiate(_cassettePrefab);
			Vector3 currentPos = cassette.transform.position;
			cassette.transform.position = new Vector3(currentPos.x, currentPos.y, currentPos.z + _cassetteSpacing);					

		}
	}
}
