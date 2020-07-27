using UnityEngine;

public class GameInititaliser : MonoBehaviour
{
    // Scripts
    private CarCollider _carCollider;
    private RoadMotor _roadMotor;
    private RoadGenerator _roadGenerator;
    private CarMovement _carMovement;
    private CarInput _carInput;
    private CameraPulse _cameraPulse;
    private MusicPlayer _musicPlayer;
    private GameManager _gameManager;
    private CameraHandler _cameraHandler;

    // UI
    [SerializeField] private GameObject _gameplayPanel;

	private void Awake()
	{
        _carCollider = FindObjectOfType<CarCollider>();
        _roadMotor = FindObjectOfType<RoadMotor>();
        _roadGenerator = FindObjectOfType<RoadGenerator>();
        _carMovement = FindObjectOfType<CarMovement>();
        _carInput = FindObjectOfType<CarInput>();
        _cameraPulse = FindObjectOfType<CameraPulse>();
        _musicPlayer = FindObjectOfType<MusicPlayer>();
        _gameManager = FindObjectOfType<GameManager>();
        _cameraHandler = FindObjectOfType<CameraHandler>();
        

    }

	private void Start()
	{
        _gameManager.IsInShop = true;
	}

	public void StartGame()
	{
       // _carCollider.enabled = true;
        _carInput.enabled = true;
        _carMovement.enabled = true;
        _roadGenerator.enabled = true;
        _roadMotor.enabled = true;
        _cameraPulse.enabled = true;
        _musicPlayer.enabled = true;

        _gameplayPanel.SetActive(true);

        _gameManager.IsInShop = false;

        _cameraHandler.SwitchToGameplayCamera();

        

    }

}
