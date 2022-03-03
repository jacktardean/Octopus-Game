using UnityEngine;

public abstract class SingletonMonobehaviour<T> : MonoBehaviour where T:MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }



    // Protected means it can be inherrited from (as this is a abstract class)
    // Virtual means it can be overridden

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
