using UnityEngine;

namespace Lofle
{	
	private class GlobalCoroutine : MonoBehaviour
	{
		private static GlobalCoroutine _instance = null;
		public static GlobalCoroutine Instance
		{
			get
			{
				if( null == _instance )
				{
					GameObject gameObject = new GameObject();
					_instance = gameObject.AddComponent<GlobalCoroutine>();
					_instance.name = nameof( GlobalCoroutine );
				}

				return _instance;
			}
		}

		private void Awake()
		{
			_instance = this;
			DontDestroyOnLoad( gameObject );
		}

		private Coroutine InvokeStartCoroutine( IEnumerator coroutine )
		{
			return StartCoroutine( coroutine );
		}

		public static Coroutine Invoke( IEnumerator coroutine )
		{
			return Instance.InvokeStartCoroutine( coroutine );
		}
	}
}