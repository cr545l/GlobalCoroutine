# Global Coroutine

전역에서 사용 가능한 코루틴,
MonoBehaviour를 상속받지 않은 클래스에서 코루틴을 호출하기 위함

SampleInvoker

```csharp
public class SampleInvoker : MonoBehaviour
{
    void Start()
    {
        NonMono.Invoke();
    }
    
```

NonMono

``` csharp
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
```