using UnityEngine;

public class MoveForward : MonoBehaviour
{
	[SerializeField] private float _speed;

	private void Update()
	{
		Vector3 vectorTarget = transform.position;
		vectorTarget.x++;
		transform.position = Vector3.MoveTowards(transform.position, vectorTarget, _speed * Time.deltaTime);
	}
}
