using System;
using System.Collections; // 确保引入IEnumerator的命名空间
using UnityEngine;
using UnityEngine.Networking;
using System.Text;
using TMPro;

[Serializable]
public class PostData
{
    public string UserName;
    public string typeEvent;
    public string time;
    public string mode;
    public string date;
    public string cubeID;
    public string answer;
    public string score;
    public string leftMoney;
}

public class FireBaseConnector : MonoBehaviour
{
    private string UserName;
    private PostData postData;
    public TMP_InputField userNameInputField;
    public string mode;
    void Update()
    {
        UserName = userNameInputField.text;
        //Debug.Log(UserName);
        //CheckNetworkConnection();
        //NextButtonEvent("str", "val");
    }
    private void CheckNetworkConnection()
    {
        StartCoroutine(TestConnection());
    }

    IEnumerator TestConnection()
    {
        using (UnityWebRequest request = UnityWebRequest.Get("https://www.google.com"))
        {
            yield return request.SendWebRequest();
            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Network error: " + request.error);
            }
            else
            {
                Debug.Log("Internet is accessible.");
            }
        }
    }
    public void SaveAnswerEvent(string cubeID, string eventType, string answer, float totalTime)
    {
        postData = new PostData
        {
            UserName = UserName,
            cubeID = cubeID,
            typeEvent = eventType,
            mode = mode,
            answer = answer,
            time = totalTime.ToString("F2") + " seconds",
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        PostToDatabase();
    }
    public void SaveFinalListToFirebase(string eventType, string answerData)
    {
        postData = new PostData
        {
            UserName = UserName,
            typeEvent = eventType,
            mode = mode,
            answer = answerData,
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };

        PostToDatabase();
    }
    public void SaveScoreEvent(string points, string eventType, string leftCoins, float totalTime)
    {
        postData = new PostData
        {
            UserName = UserName,
            leftMoney = leftCoins,
            typeEvent = eventType,
            mode = mode,
            score = points,
            time = totalTime.ToString("F2") + " seconds",
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        PostToDatabase();
    }
    public void SaveFinalScoreEvent(string eventType, string score, string leftMoney)
    {
        postData = new PostData
        {
            UserName = UserName,
            typeEvent = eventType,
            mode = mode,
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        PostToDatabase();
    }

    public void SaveTotalTimeEvent(string eventType, float totalTime)
    {
        postData = new PostData
        {
            UserName = UserName,
            typeEvent = eventType,
            time = totalTime.ToString("F2") + " seconds",
            mode = mode,
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        PostToDatabase();
    }

    private void PostToDatabase()
    {
        string jsonData = JsonUtility.ToJson(postData);
        StartCoroutine(Post("https://salucity-d1352-default-rtdb.firebaseio.com/records.json", jsonData));
    }

    IEnumerator Post(string url, string json)
    {
        byte[] jsonToSend = new UTF8Encoding().GetBytes(json);
        using (UnityWebRequest request = UnityWebRequest.Post(url, UnityWebRequest.kHttpVerbPOST))
        {
            request.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonToSend);
            request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("Error posting data: " + request.error);
            }
            else
            {
                Debug.Log("Data posted successfully!");
                Debug.Log("Response: " + request.downloadHandler.text);
            }
        }
    }
}