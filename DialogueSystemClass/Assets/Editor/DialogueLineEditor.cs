using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[CustomEditor(typeof(DialogueLineData))]
public class DialogueLineEditor : EditorWindow
{
    DialogueLineData targetLine = null;

    public override VisualElement CreateInspectorGUI()
    {
        // Each editor window contains a root VisualElement object
        var editorAsset = AssetDataBase.
            LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/DialogueLineEditor.uxml");

        var root = editorAsset.CloneTree();

        targetLine = target as DialogueLineData;

        var nameLabel = root.Query<Label>("NameLabel").First();
        nameLabel.text = targetLine.name;

        var audioClip = new ObjectField();
        audioClip.objectType = typeof(audioClip);
        audioClip.bindigPath = "dialogueAudio";
        audioClip.Bind(serializedObject);

        root.Add(audioClip);

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);

        return root;
    }
}