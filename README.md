# Global Coroutine

전역에서 사용 가능한 코루틴,
MonoBehaviour를 상속받지 않은 클래스에서 코루틴을 호출하기 위함

SampleInvoker 클래스

Unity의 Start 시점에서 예제 코드를 호출하기 위해 있는 클래스

```csharp
public class SampleInvoker : MonoBehaviour
{
    void Start()
    {
        NonMono.Invoke();
    }
}
```

NonMono 클래스

해당 클래스는 `MonoBehaviour`를 상속받지 않았으나 StartCoroutine과 동일한 동작이 가능합니다.

``` csharp
public static class NonMono
{
    public static void Invoke()
    {
        Lofle.GlobalCoroutine.Invoke( Update() ); // <- StartCoroutine과 동일
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
```