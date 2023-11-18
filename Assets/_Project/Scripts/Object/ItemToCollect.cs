// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using _Project.Scripts.Character;
using UnityEngine;

namespace _Project.Scripts.Object
{
	/// <summary>
	/// Untuk handle Item yang mau di collect
	/// </summary>
	public class ItemToCollect : MonoBehaviour, ICollectable
	{
		[SerializeField] private string id;
		public string ID { get => id; }


		
		
		public void Collect()
		{
			CharacterEvents.OnCollect?.Invoke(this);
			Destroy(gameObject);
		}
	}
}
