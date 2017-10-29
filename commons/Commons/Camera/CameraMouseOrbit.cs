using UnityEngine;

namespace Commons.Camera
{
	[AddComponentMenu ("Camera-Control/Mouse Orbit")]
	public class CameraMouseOrbit : MonoBehaviour
	{
		void Start ()
		{
			Vector3 angles = transform.eulerAngles;
			x = angles.y;
			y = angles.x;

			Rigidbody rb = GetComponent<Rigidbody> ();

			// Make the rigid body not change rotation
			if (rb != null)
				rb.freezeRotation = true;
		}

		void LateUpdate ()
		{
			x += getMouseX () * xSpeed * 0.02f;
			y -= getMouseY () * ySpeed * 0.02f;

			y = ClampAngle ((int)y, yMinLimit, yMaxLimit);

			Quaternion rotation = Quaternion.Euler (y, x, 0);
			Vector3 position = rotation * new Vector3 (0.0f, 0.0f, -distance) + target.position;

			transform.rotation = rotation;
			transform.position = position;
		}

		static float getMouseX ()
		{
			return Input.GetAxis ("Mouse X");
		}

		static float getMouseY ()
		{
			return Input.GetAxis ("Mouse Y");
		}

		static int ClampAngle (int angle, int min, int max)
		{
			if (angle < -360)
				angle += 360;
			if (angle > 360)
				angle -= 360;
			return Mathf.Clamp (angle, min, max);
		}

		#region Attributes

		[SerializeField]
		Transform target;

		[SerializeField]
		float distance;

		[SerializeField]
		float xSpeed;
		[SerializeField]
		float ySpeed;

		[SerializeField]
		int yMinLimit;
		[SerializeField]
		int yMaxLimit;

		float x, y;

		#endregion

		public CameraMouseOrbit ()
		{
			distance = 7.0f;

			xSpeed = 250.0f;
			ySpeed = 120.0f;

			yMinLimit = -10;
			yMaxLimit = 85;
		}
	}



}
