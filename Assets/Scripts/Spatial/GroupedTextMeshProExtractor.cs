using System.Collections.Generic;
using System.Text;
using UnityEngine;
using TMPro;

public class GroupedTextMeshProExtractor : MonoBehaviour
{
    public List<GameObject> groups;

    public string GetFormattedActiveTextMeshProData()
    {
        StringBuilder result = new StringBuilder();

        foreach (GameObject group in groups)
        {
            TextMeshPro activeTextMeshPro = null;

            foreach (Transform child in group.transform)
            {
                if (child.gameObject.activeSelf)
                {
                    activeTextMeshPro = child.GetComponent<TextMeshPro>();
                    if (activeTextMeshPro != null)
                    {
                        string groupName = group.name;
                        result.AppendLine($"{groupName}: {activeTextMeshPro.text}, ");
                        break;
                    }
                }
            }
        }

        Debug.Log("Formatted TextMeshPro data: \n" + result.ToString());
        return result.ToString();
    }
}