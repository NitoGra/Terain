using UnityEngine;

public class GrowingSize : MonoBehaviour
{
	[SerializeField] private float _speed;

	void Update()
    {
		float scale = transform.localScale.y + _speed;
		transform.localScale = new Vector3(scale,scale,scale); ;
	}
}
