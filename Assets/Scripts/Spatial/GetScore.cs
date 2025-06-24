using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using TMPro;
using UnityEngine.UIElements;

public class GetScore : MonoBehaviour
{
    // Start is called before the first frame update
    public FireBaseConnector fireBaseConnector;
    public GetAttibuteData scoreManager;
    public TextMeshProUGUI points;
    public TextMeshProUGUI leftCoins;
    private float startTime;
    private float totaltime;
    void OnEnable ()
    {
        startTime = Time.time;
    }
    void OnDisable()
    {
        float endTime = Time.time;
        totaltime = endTime - startTime;
    }
    public void SendScoreToDatabase(string eventType)
    {   
        SaveScoreEvent(points.text, eventType, leftCoins.text, totaltime);
    }
    private void SaveScoreEvent(string points, string eventType, string leftCoins, float totaltime)
    {
        fireBaseConnector.SaveScoreEvent(points, eventType, leftCoins, totaltime);
    }
}
