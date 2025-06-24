using UnityEngine;

public class SendDataController : MonoBehaviour
{
    public GroupedTextMeshProExtractor textMeshProExtractor;
    public FireBaseConnector firebaseConnector;

    public void SendDataToFirebase(string eventType)
    {
        string answerData = textMeshProExtractor.GetFormattedActiveTextMeshProData();
        firebaseConnector.SaveFinalListToFirebase(eventType, answerData);
    }
}