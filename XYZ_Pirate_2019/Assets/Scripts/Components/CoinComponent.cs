using UnityEngine;

namespace Scripts.Components
{
	public class CoinComponent : MonoBehaviour
	{
		//[SerializeField] private GameObject _coin;

		private void OnTriggerEnter2D()
		{
			string _coinTag = gameObject.tag;

			if (_coinTag != null)
			{
				WalletManager.AddCoin(_coinTag);
				WalletManager.SayCoinCount();
			}
			else
			{
				Debug.Log("У монетки нет тега!");
			}
		}
	}
}

