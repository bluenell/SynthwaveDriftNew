using UnityEngine;
public class CarInput : MonoBehaviour
{
	public float HorizontalAxis => Input.GetAxis(InputManager.HorizontalAxis);
	
}
