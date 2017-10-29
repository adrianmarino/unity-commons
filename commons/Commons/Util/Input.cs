﻿using UnityEngine;

namespace Commons.Util
{
	public class Input
	{
		public static bool NextWeaponButton ()
		{
			return UnityEngine.Input.GetKeyDown (KeyCode.E);
		}

		public static bool PreviousWeaponButton ()
		{
			return UnityEngine.Input.GetKeyDown (KeyCode.Q);
		}

		public static bool GetRunButton ()
		{
			return UnityEngine.Input.GetButton (RUN);
		}

		public static bool IsMoving ()
		{
			return HorizontalMovementDelta () != 0 || VerticalMovementDelta () != 0;
		}

		public static void HideCursor (bool value)
		{
			if (value)
				HideCursor ();
			else
				ShowCursor ();
		}

		public static void HideCursor ()
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}


		public static void ShowCursor ()
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}

		public static Vector2 KeyboardHorVerMovementDelta ()
		{
			return new Vector2 (
				HorizontalMovementDelta (), 
				VerticalMovementDelta ()
			);
		}

		public static Vector2 MouseHorVerMovementDelta ()
		{
			return new Vector2 (
				MouseHorizontalMovementDelta (), 
				MouseVercalMovementDelta ()
			);
		}

		public static float MouseHorizontalMovementDelta ()
		{
			return MovementDelta (MOUSE_X);
		}

		public static float MouseVercalMovementDelta ()
		{
			return MovementDelta (MOUSE_Y);
		}

		public static float HorizontalMovementDelta ()
		{
			return MovementDelta (HORIZONTAL);
		}

		public static float VerticalMovementDelta ()
		{
			return MovementDelta (VERTICAL);
		}

		public static float MovementDelta (string axisName)
		{
			return UnityEngine.Input.GetAxisRaw (axisName);
		}

		public static bool GetJumpButtonDown ()
		{
			return UnityEngine.Input.GetButtonDown (JUMP);
		}

		public static bool GetJumpButtonUp ()
		{
			return UnityEngine.Input.GetButtonUp (JUMP);
		}

		public static bool GetFireButton ()
		{
			return UnityEngine.Input.GetButton (FIRE_1);
		}

		public static bool GetReloadButton ()
		{
			return UnityEngine.Input.GetButtonDown (RELOAD);
		}

		public static bool GetFireButtonUp ()
		{
			return UnityEngine.Input.GetButtonUp (FIRE_1);
		}

		public static bool GetFireButtonDown ()
		{
			return UnityEngine.Input.GetButtonDown (FIRE_1);
		}

		//-----------------------------------------------------------------------------
		// Constants
		//-----------------------------------------------------------------------------

		private const string FIRE_1 = "Fire1";

		private const string JUMP = "Jump";

		private const string RUN = "Run";

		private const string VERTICAL = "Vertical";

		private const string HORIZONTAL = "Horizontal";

		private const string MOUSE_X = "Mouse X";

		private const string MOUSE_Y = "Mouse Y";

		private const string RELOAD = "Reload";

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		private Input ()
		{
		}
	}
}
