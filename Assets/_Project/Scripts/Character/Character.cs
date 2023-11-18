// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using System.Collections.Generic;
using _Project.Scripts.AbilitySystem;
using _Project.Scripts.AbilitySystem.CollectAbility;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Project.Scripts.Character
{
	public class Character : MonoBehaviour
	{
		[Header("Input")]
		[SerializeField] private CharacterInput characterInput;
		
		[Header("Ability")]
		public CollectAbility collectAbility;
		
		// setter getter
		public CharacterInput CharacterInput => characterInput;
	}
}
