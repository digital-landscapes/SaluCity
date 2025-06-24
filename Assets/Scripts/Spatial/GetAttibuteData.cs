using UnityEngine;

public class GetAttibuteData : MonoBehaviour
{
    void Start()
    {
        string objectName = gameObject.name;
    }

    public string GetObjectName()
    {
        return gameObject.name;
    }
}