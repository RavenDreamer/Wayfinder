﻿using Discord;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace NethysBot.Models
{
	public class Character
	{
		/// <summary> 
		/// Individual per-user settings
		/// </summary>
		public Dictionary<ulong,UserSettings> Owners { get; set; } = new Dictionary<ulong, UserSettings>();
		/// <summary>
		/// ID on characters.pf2.tools.
		/// </summary>
		[BsonId]
		public string RemoteId { get; set; }
		/// <summary>
		/// Character Name for easy querying.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Cache of the Values
		/// </summary>
		public string Values { get; set; }
		/// <summary>
		/// Date of the last time the sheet's values were updated
		/// </summary>
		public DateTime ValuesLastUpdated { get; set; }
		/// <summary>
		/// Date of the last time the sheet was updated.
		/// </summary>
		public DateTime LastUpdated { get; set; }
		/// <summary>
		/// Whether or not this is a character sheet or a companion sheet.
		/// </summary>
		public SheetType Type { get; set; }
		/// <summary>
		/// Url of the character's thumbnail image
		/// </summary>
		public string ImageUrl { get; set; }
		/// <summary>
		/// Url of the character's familiar
		/// </summary>
		public string FamImg { get; set; }

	}
	public enum SheetType { Character, Companion }
	public enum Score { strength, dexterity, constitution, intelligence, wisdom, charisma }
	public class UserSettings
	{
		public ulong Id { get; set; }
		public int[] Color { get; set; } = null;
		public string ImageUrl { get; set; }
	}
}
