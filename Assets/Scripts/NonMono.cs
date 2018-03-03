using System.Collections;
using UnityEngine;

public static class NonMono
{
	public static void Invoke()
	{
		Lofle.GlobalCoroutine.Invoke( Update() );
	}

	private static IEnumerator Update()
	{
		for( int i = 0; i < 10; ++i )
		{
			Debug.Log( i );
			yield return null;
		}
	}
}
