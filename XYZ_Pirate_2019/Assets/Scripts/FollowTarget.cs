using UnityEngine;


namespace Scripts
{
	public class FollowTarget : MonoBehaviour
	{
		[SerializeField] private Transform _target;
		[SerializeField] private float _damping;

		private void LateUpdate()
		{
			var detination = new Vector3(_target.position.x, _target.position.y, transform.position.z);
			transform.position = Vector3.Lerp(transform.position, detination, Time.deltaTime * _damping);
		}
	}

}

