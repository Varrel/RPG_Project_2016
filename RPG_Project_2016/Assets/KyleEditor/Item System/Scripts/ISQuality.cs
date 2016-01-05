﻿// Kyle Bull
// RPG Project 2016
// Item System

using UnityEngine;
using System.Collections;

namespace KyleBull.ItemSystem
{
	[System.Serializable]
	public class ISQuality : IISQuality
	{
		[SerializeField]string _name;
		[SerializeField]Sprite _icon;

		public ISQuality ()
		{
			_name = "Quality";
			_icon = new Sprite ();
		}

		public string Name {
			get {
				return _name;
			}
			set {
				_name = value;
			}
		}

		public Sprite Icon {
			get {
				return _icon;
			}
			set {
				_icon = value;
			}
		}
	}
}