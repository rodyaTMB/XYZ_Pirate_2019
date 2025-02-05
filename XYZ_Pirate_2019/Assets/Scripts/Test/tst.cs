using UnityEngine;

namespace Scrits.Test
{
	public class tst : MonoBehaviour
	{
		int a = 1;
		int b = 2;

		private void Update()
		{
			if (a < b) return;

			int asd = 2;
			Debug.Log(asd);
		}

	}
}


