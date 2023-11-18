// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using System;
using _Project.Scripts.Object;
using UnityEngine;

namespace _Project.Scripts.Character
{
	public class CharacterEvents : MonoBehaviour
	{
		public static Action<ICollectable> OnCollect;
		public static Action OnQuestObjectiveChanged;
	}
}
