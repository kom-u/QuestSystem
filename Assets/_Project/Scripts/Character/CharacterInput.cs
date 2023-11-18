// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Project.Scripts.Character
{
	public class CharacterInput : MonoBehaviour
	{
		[SerializeField] private Character character;



		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Q))
			{
				character.collectAbility.Action();
			}
		}
	}
}
