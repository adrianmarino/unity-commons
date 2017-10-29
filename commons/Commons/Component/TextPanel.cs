﻿using UnityEngine;
using UnityEngine.UI;

namespace Commons.Component
{
	[RequireComponent (typeof(Text))]
	public abstract class TextPanel : MonoBehaviour
	{
		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public void Clean ()
		{
			Value = "";
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		protected string Value {
			get { return Self ().text; }
			set { Self ().text = value; }
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private Text Self ()
		{
			return GetComponent<Text> ();
		}
	}
}

