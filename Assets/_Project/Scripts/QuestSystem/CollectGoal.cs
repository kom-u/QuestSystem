// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using _Project.Scripts.Character;
using _Project.Scripts.Object;
using UnityEngine;

namespace _Project.Scripts.QuestSystem
{
	[CreateAssetMenu(menuName = "QuestSystem/CollectGoal")]
	public class CollectGoal : Goal
	{
		public string ItemID;
		
		


		public override void Init()
		{
			base.Init();
			
			CharacterEvents.OnCollect += CharacterEvents_OnCollect;
		}
		
		
		private void CharacterEvents_OnCollect(ICollectable _item)
		{
			if (_item.ID != ItemID) 
				return;

			CurrentAmount++;
			Evaluate();
			
			CharacterEvents.OnQuestObjectiveChanged?.Invoke();
		}
	}
}
