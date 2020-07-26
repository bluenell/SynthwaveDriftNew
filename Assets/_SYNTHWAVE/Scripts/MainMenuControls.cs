using UnityEngine;

public class MainMenuControls : MonoBehaviour
{
	public void PlayGame()
	{
		SceneSwitcher.SwitchScene(1);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
