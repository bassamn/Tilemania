using UnityEngine;

public class EventSystem : MonoBehaviour
{
    void Awake()
    {
        if (FindObjectsByType<EventSystem>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
