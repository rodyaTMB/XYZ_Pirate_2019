using System;
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
	private Animator _animator;
	private SpriteRenderer _sprite;

	private static readonly int isGround = Animator.StringToHash("IsGround"); 
	private static readonly int verticalVelocity = Animator.StringToHash("Vertical-velocity"); 
	private static readonly int isRoning = Animator.StringToHash("IsRoning"); 


	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		_animator = GetComponent<Animator>();
		_sprite = GetComponent<SpriteRenderer>();
	}

	void FixedUpdate()
	{
		_rigidbody.velocity = new Vector2(_direction.x * _speed, _rigidbody.velocity.y);

		var isJumping = _direction.y > 0;
		var isGrounded = IsGrounded();
		if (isJumping)
		{
			if (isGrounded)
			{
				_rigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
			}
		}
		else if (_rigidbody.velocity.y > 0)
		{
			_rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y * 0.5f);
		}

		_animator.SetBool(isGround, isGrounded);
		_animator.SetFloat(verticalVelocity, _rigidbody.velocity.y);
		_animator.SetBool(isRoning, _direction.x != 0);

		UpdateSpriteDirection();		
	}

	private void UpdateSpriteDirection()
	{
		if (_direction.x > 0)
		{
			_sprite.flipX = false;
		}
		else if (_direction.x < 0)
		{
			_sprite.flipX = true;
		}
	}

	public void SetDirection(Vector2 directioin)
	{
		_direction = directioin;

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
