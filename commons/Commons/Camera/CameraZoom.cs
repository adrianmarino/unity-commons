using UnityEngine;
using System;

namespace Commons.Camera
{
	[AddComponentMenu ("Camera-Control/Camera Zoom")]
	public class CameraZoom : MonoBehaviour
	{
		#region Attributes

		[SerializeField]
		UnityEngine.Camera camera;

		bool zoomIn, zoomOut;

		#endregion

		void Start ()
		{
			camera = GetComponent<UnityEngine.Camera> ();
			zoomOut = zoomIn = true;
		}

		void Update ()
		{
			if (camera.fieldOfView <= 30)
				zoomIn = false;

			if (camera.fieldOfView >= 30)
				zoomIn = true;

			if (camera.fieldOfView >= 60)
				zoomOut = false;

			if (camera.fieldOfView < 60)
				zoomOut = true;
		
			if (this.getMoseuWheel () < 0 && zoomOut == true)
				camera.fieldOfView += 3;
		
			if (this.getMoseuWheel () > 0 && zoomIn == true)
				camera.fieldOfView -= 3;
		}

		float getMoseuWheel ()
		{
			return Input.GetAxis ("Mouse ScrollWheel");
		}
	}

}
