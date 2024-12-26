using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputReader : MonoBehaviour
{
	[SerializeField] private HeroPirate _heroPirate;

	void Awake()
	{
		//_heroPirate = GetComponent<HeroPirate>();
	}

	void Update()
	{
		LegacyMove();
	}

	public void LegacyMove()
	{
		var horizontal = Input.GetAxis("Horizontal");
		_heroPirate.SetDirectionX(horizontal);

		var vertical = Input.GetAxis("Vertical");
		_heroPirate.SetDirectionY(vertical);
	}

	public void Move()
	{
		if (Input.GetKey(KeyCode.A))
		{
			_heroPirate.SetDirectionX(-1f);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			_heroPirate.SetDirectionX(1f);
		}
		else
		{
			_heroPirate.SetDirectionX(0);
		}
	}
}
