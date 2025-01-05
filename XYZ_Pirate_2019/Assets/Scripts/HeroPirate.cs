using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPirate : MonoBehaviour
{

	[SerializeField] float _speed;
	[SerializeField] float _jumpPower;

	Vector2 _drirection;

	float _directionX;
	float _directionY;

	void Update()
	{
		MoveT();
	}

	public void SetDirection(Vector2 directioin)
	{
		_drirection = directioin;
	}

	public void MoveT()
	{
		if(_drirection.magnitude > 0)
		{
			var delta = _drirection * _speed * Time.deltaTime;
			transform.position = transform.position + new Vector3(delta.x, delta.y, transform.position.z);
		}
	}

	public void SetDirectionX(float direction)
	{
		_directionX = direction;
	}
	public void SetDirectionY(float direction)
	{
		_directionY = direction * _jumpPower;
	}

	public void SaySomething()
	{
		Debug.Log("Саламалейкум ");
	}


	public void MyMove()
	{
		if (_directionX != 0 || _directionY != 0)
		{

			var deltaX = _directionX * _speed * Time.deltaTime;
			var deltaY = _directionY * _speed * Time.deltaTime;


			var newXPosition = transform.position.x + deltaX;
			var newYPosition = transform.position.y + deltaY;

			transform.position = new Vector3(newXPosition, newYPosition, transform.position.z);
		}
	}
}
