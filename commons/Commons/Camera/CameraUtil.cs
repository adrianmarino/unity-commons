using System;
using UnityEngine;

namespace Commons.Camera
{
	public class CameraUtil
	{
		public static void setEnable (UnityEngine.Camera camera, bool value)
		{
			camera.enabled = value;

			AudioListener audioListener = camera.GetComponent<AudioListener> ();
			if (audioListener != null)
				audioListener.enabled = value;
		}

		private CameraUtil ()
		{
		}
	}
}

