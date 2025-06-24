using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAnswer : MonoBehaviour
{
    // Start is called before the first frame update
    public FireBaseConnector fireBaseConnector;
    public GetAttibuteData cubeIDName;
    public GetAttibuteData answerText;
    private float startTime;
    private float totaltime;

    void OnEnable ()
    {
        startTime = Time.time;
    }

    public void SendAnswerToDatabase(string eventType)
    {
        string cubeID = cubeIDName.GetObjectName();
        string answer = answerText.GetObjectName();
        float endTime = Time.time;
        float totaltime = endTime - startTime;
        SaveAnswerEvent(cubeID, eventType, answer, totaltime);
    }

    private void SaveAnswerEvent(string cubeID, string eventType, string answer, float totaltime)
    {
        fireBaseConnector.SaveAnswerEvent(cubeID, eventType, answer, totaltime);
    }
}
