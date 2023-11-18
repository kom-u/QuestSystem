// ==================================================
// 
//   Created by Atqa Munzir
// 
// ==================================================

using System;
using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Character;
using UnityEngine;

namespace _Project.Scripts.QuestSystem
{
	public class Quest : MonoBehaviour
	{
		public List<Goal> GoalList = new List<Goal>();
		public string QuestName;
		public string Description;
		public int ExperienceReward;
		
		public bool IsCompleted { get; set; }




		private void Awake()
		{
			GoalList.ForEach(_goal => _goal.Init());
		}


		private void OnEnable()
		{
			CharacterEvents.OnQuestObjectiveChanged += CheckGoals;
		}


		public void CheckGoals()
		{
			IsCompleted = GoalList.All(_goal => _goal.IsCompleted);
			// IsCompleted = IsGoalCompleted();
			
			if (IsCompleted) Debug.Log("Completed Quest");
		}


		private bool IsGoalCompleted()
		{
			for (int i = 0; i < GoalList.Count; i++)
			{
				if (GoalList[i].IsCompleted) continue;

				return false;
			}

			return true;
		}
	}
}
