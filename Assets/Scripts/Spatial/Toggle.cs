using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject targetObject;

    public void ToggleObjectActive()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}