using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPirate : MonoBehaviour
{

	[SerializeField] float _speed;

	float _directionX;

	public void SetDirectionX(float direction)
	{
		_directionX = direction;
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
		if (_directionX != 0)
		{

			var deltaX = _directionX * _speed * Time.deltaTime;


			var newXPosition = transform.position.x + deltaX;

			transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
		}
	}
}
