// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using _Project.Scripts.Character;
using UnityEngine;

namespace _Project.Scripts.QuestSystem
{
	public class Goal : ScriptableObject
	{

		public string Description;
		public bool IsCompleted { get; set; }

		public int TargetAmount;
		public int CurrentAmount { get; set; }




		public virtual void Init()
		{
			CurrentAmount = 0;
			IsCompleted = false;
		}


		public void Evaluate()
		{
			if (CurrentAmount >= TargetAmount)
			{
				Complete();
			}
		}


		public void Complete()
		{
			IsCompleted = true;
		}
	}
}
