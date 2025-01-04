using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPirate : MonoBehaviour
{

	[SerializeField] float _speed;

	float _directionX;
	float _directionY;

	public void SetDirectionX(float direction)
	{
		_directionX = direction;
	}
	public void SetDirectionY(float direction)
	{
		_directionY = direction;
	}

	public void SaySomething()
	{
		Debug.Log("Саламалейкум ");
	}

	void Update()
	{
		Move();
	}

	public void Move()
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
