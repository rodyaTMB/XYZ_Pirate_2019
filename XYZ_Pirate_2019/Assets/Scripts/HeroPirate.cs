using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPirate : MonoBehaviour
{

	[SerializeField] float _speed;
	[SerializeField] float _jumpPower;
	[Space]
	//[SerializeField] private LayerMask _groundLayer;

	[SerializeField] private LayerCheck _groundCheck;
	//[Space]
	//[Space]
	//[SerializeField] private float _groundCheckRadius;
	//[SerializeField] private Vector3 _groundCheckPositionDelta;


	private Rigidbody2D _rigidbody;
	Vector2 _direction;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}
	public void SetDirection(Vector2 directioin)
	{
		_direction = directioin;

	}

	void FixedUpdate()
	{
		_rigidbody.velocity = new Vector2(_direction.x * _speed, _rigidbody.velocity.y);

		var isJumping = _direction.y > 0;
		if (isJumping)
		{
			if (IsGrounded())
			{
				_rigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
			}
			else if (_rigidbody.velocity.y > 0)
			{
				_rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y * 0.5f);
			}
		}
	}
	private bool IsGrounded()
	{
		return _groundCheck.IsTouchingLayer;
		//var hit = Physics2D.CircleCast(transform.position + _groundCheckPositionDelta, _groundCheckRadius, Vector2.down, 0, _groundLayer);
		//return hit.collider != null;
	}
	public void SaySomething()
	{
		Debug.Log("Саламалейкум ");
	}

	//public void MoveT()
	//{
	//	if (_direction.magnitude > 0)
	//	{
	//		var delta = _direction * _speed * Time.fixedDeltaTime;
	//		transform.position = transform.position + new Vector3(delta.x, delta.y, transform.position.z);
	//	}
	//}




	//private void OnDrawGizmos()
	//{
	//	Gizmos.color = IsGrounded() ? Color.green : Color.red;
	//	Gizmos.DrawSphere(transform.position, 0.3f);
	//}

	//float _directionX;
	//float _directionY;

	//public void SetDirectionX(float direction)
	//{
	//	_directionX = direction;
	//}
	//public void SetDirectionY(float direction)
	//{
	//	_directionY = direction * _jumpPower;
	//}

	//public void MyMove()
	//{
	//	if (_directionX != 0 || _directionY != 0)
	//	{

	//		var deltaX = _directionX * _speed * Time.deltaTime;
	//		var deltaY = _directionY * _speed * Time.deltaTime;


	//		var newXPosition = transform.position.x + deltaX;
	//		var newYPosition = transform.position.y + deltaY;

	//		transform.position = new Vector3(newXPosition, newYPosition, transform.position.z);
	//	}
	//}
}
