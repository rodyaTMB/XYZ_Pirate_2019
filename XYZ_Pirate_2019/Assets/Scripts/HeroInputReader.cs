using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
	[SerializeField] private HeroPirate _heroPirate;

	public void OnHorizontalMovement(InputAction.CallbackContext context)
	{
		var direction = context.ReadValue<float>();
		_heroPirate.SetDirectionX(direction);
	}

	public void OnSaySomething(InputAction.CallbackContext context)
	{
		if (context.canceled)
		{
			_heroPirate.SaySomething();
		}
	}
}
