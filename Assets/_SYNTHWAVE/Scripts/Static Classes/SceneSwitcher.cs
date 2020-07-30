using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneSwitcher
{
	public static void SwitchScene(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}
}
