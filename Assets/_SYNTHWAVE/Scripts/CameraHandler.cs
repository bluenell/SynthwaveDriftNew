using UnityEngine;

public class CameraHandler : MonoBehaviour{

    [SerializeField] private Cinemachine.CinemachineVirtualCamera _gameplayCam;
    [SerializeField] private Cinemachine.CinemachineVirtualCamera _shopCam;

	private void Start()
	{
        SwitchToShopCamera();
	}

	public void SwitchToShopCamera()
	{
        _gameplayCam.Priority = 0;
        _shopCam.Priority = 1;
	}

    public void SwitchToGameplayCamera()
	{
        _gameplayCam.Priority = 1;
        _shopCam.Priority = 0;
    }

    


}
