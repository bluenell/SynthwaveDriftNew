
using UnityEngine;

public class CarCollider : MonoBehaviour
{

	public delegate void CollisionDetector();
	public event CollisionDetector Collided;
	
	private void OnCollisionEnter(Collision collision)
	{
		MonoBehaviour[] monoBehaviours = collision.gameObject.GetComponents<MonoBehaviour>();

		foreach (MonoBehaviour mb in monoBehaviours)
		{
			if (mb is ICollectable)
			{
				ICollectable collectable = (ICollectable)mb;
				collectable.Collect();
			}
			else if (mb is IHittable)
			{
				IHittable killable = (IHittable)mb;
				killable.Hit();
			}

		}
	}
}
			