using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue System/Dialogue Data")]
public class DialogueDatabase : ScriptableObject
{
    public DialogueLineData[] data;
}
