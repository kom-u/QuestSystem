// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using System;
using _Project.Scripts.Character;
using _Project.Scripts.Object;
using _Project.Scripts.QuestSystem;
using UnityEngine;

namespace _Project.Scripts.AbilitySystem.CollectAbility
{
	/// <summary>
	/// Handle trigger ke item yang bisa di collect
	/// </summary>
	public class CollectAbility : CharacterAbility
	{
		private ICollectable itemToCollect;


		private void OnTriggerEnter(Collider other)
		{
			if (other.CompareTag("Item"))
			{
				itemToCollect = other.gameObject.GetComponent<ICollectable>();
			}
		}


		private void OnTriggerExit(Collider other)
		{
			if (other.CompareTag("Item"))
			{
				itemToCollect = null;
			}
		}


		public override void Action()
		{
			if (itemToCollect == null) return;
			
			itemToCollect.Collect();
		}
	}
}
