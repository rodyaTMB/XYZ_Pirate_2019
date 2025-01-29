using UnityEngine;

namespace Scripts
{	public class WalletManager : MonoBehaviour
	{
		private static int _coinCount;

		public static void AddCoin(string tag)
		{
			if (tag == "SilverCoin")
			{
				_coinCount += 1;
			}
			else
			{
				_coinCount += 10;
			}
		}

		public static void SayCoinCount()
		{
			Debug.Log($"У тебя: {_coinCount} денег!");
		}
	}
}


