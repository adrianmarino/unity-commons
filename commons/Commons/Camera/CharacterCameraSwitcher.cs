using UnityEngine;

namespace Commons.Camera
{
	[AddComponentMenu ("Camera-Control/Character Camera Switch")]
	public class CharacterCameraSwitcher : MonoBehaviour
	{
		void Update ()
		{
			if (Input.GetKeyDown (firstPersonKey)) {
				CameraUtil.setEnable (thirdPersonCamera, false);
				CameraUtil.setEnable (firstPersonCamera, true);
			} else if (Input.GetKeyDown (thirdPersonKey)) {
				CameraUtil.setEnable (firstPersonCamera, false);
				CameraUtil.setEnable (thirdPersonCamera, true);
			}
		}

		void Start ()
		{
			firstPersonCamera.enabled = false;
			thirdPersonCamera.enabled = true;
		}

		#region Attributes

		[SerializeField]
		string firstPersonKey;

		[SerializeField]
		string thirdPersonKey;

		[SerializeField]
		UnityEngine.Camera firstPersonCamera;

		[SerializeField]
		UnityEngine.Camera thirdPersonCamera;

		#endregion

		public CharacterCameraSwitcher ()
		{
			firstPersonKey = "1";
			thirdPersonKey = "2";
		}
	}
}