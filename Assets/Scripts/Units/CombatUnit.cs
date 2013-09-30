﻿using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Units
{
	/// <summary>
	/// Represents a Unit asset within the game.
	/// </summary>
	public class CombatUnit : ScriptableObject
	{
		/// <summary>
		/// Squad space occupied by this unit.
		/// </summary>
		public enum UnitSpace
		{
			OneByOne,
			OneByTwo,
			TwoByOne,
			TwoByTwo
		}
		
		/// <summary>
		/// Unit name.
		/// </summary>
		public string Name;
		
		/// <summary>
		/// Unit's total health value.
		/// </summary>
		public int Health;
		
		/// <summary>
		/// Unit Attack Strength.
		/// </summary>
		public int Strength;
		
		/// <summary>
		/// Unit Attack Resistance.
		/// </summary>
		public int Toughness;
		
		/// <summary>
		/// Unit's contribution to the <see cref="Units.CombatSquad" /> movement speed.
		/// </summary>
		public int Speed;
		
		/// <summary>
		/// Unit's attack range (contributes to <see cref="Units.CombatSquad" /> attack range.
		/// </summary>
		public int Range;
		
		/// <summary>
		/// Unit's Upkeep Cost.
		/// </summary>
		public int Cost;
		
		/// <summary>
		/// Unit's adjustment to the player's starting honor.
		/// </summary>
		public int HonorMod;
		
		/// <summary>
		/// Amount of space occupied by the unit.
		/// </summary>
		public UnitSpace Space;
		
		/// <summary>
		/// Number of Squad seats taken up by this unit.
		/// </summary>
		public int UnitSize;
	}
}