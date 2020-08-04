using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Collectable : MonoBehaviour
{
	[Header("Collectable Settings")]
	[SerializeField] float _rotationAmount;
	[SerializeField] float _movementSpeed;
	[SerializeField] float _movementHeight;

	private void FixedUpdate()
	{
		transform.Rotate(0, _rotationAmount * Time.deltaTime, 0);

		/*
		Vector3 position = transform.position;
		float newY = Mathf.Sin(Time.time * _movementSpeed);
		transform.position = new Vector3(position.x, newY, position.z);
		*/
	}
}
