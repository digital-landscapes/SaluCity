using System.Collections.Generic;
using UnityEngine;

public class TimeTracker : MonoBehaviour
{
    private Dictionary<string, float> startTimes = new Dictionary<string, float>();
    public FireBaseConnector fireBaseConnector;

    public void StartTimer(string eventType)
    {
        if (!startTimes.ContainsKey(eventType))
        {
            float startTime = Time.time;
            startTimes[eventType] = startTime;
            Debug.Log("Timer started for event '" + eventType + "' at: " + startTime);
        }
        else
        {
            Debug.LogWarning("Timer for event '" + eventType + "' is already running.");
        }
    }

    public void StopTimer(string eventType)
    {
        if (startTimes.ContainsKey(eventType))
        {
            float endTime = Time.time;
            float startTime = startTimes[eventType];
            float totalTime = endTime - startTime;
            startTimes.Remove(eventType);
            Debug.Log("Timer stopped for event '" + eventType + "' at: " + endTime);
            Debug.Log("Total time for event '" + eventType + "': " + totalTime + " seconds");

            SaveTimeToDatabase(eventType, totalTime);
        }

    }

    public void ClearStartTimer(string eventType)
    {
        startTimes.Remove(eventType);
    }

    private void SaveTimeToDatabase(string eventType, float totalTime)
    {
        Debug.Log("Saving time data to the database for event '" + eventType + "': " + totalTime);
        fireBaseConnector.SaveTotalTimeEvent(eventType, totalTime);
    }
}