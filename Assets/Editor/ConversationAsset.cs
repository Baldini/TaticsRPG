using UnityEngine;
using UnityEditor;

public class ConversationAsset
{

    [MenuItem("Assets/Create/Conversation Data")]
    public static void CreateConversationData()
    {
        ScriptableObjectUtility.CreateAsset<ConversationData>();
    }
}
