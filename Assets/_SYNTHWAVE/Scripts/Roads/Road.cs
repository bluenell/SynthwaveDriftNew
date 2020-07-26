using UnityEngine;

public class Road : MonoBehaviour
{
	public float GetRoadSize()
	{
		float size = transform.GetChild(0).GetComponent<MeshRenderer>().bounds.size.z;
		// Getting the size of the mesh in world units		
		
		return size;
	}

}
