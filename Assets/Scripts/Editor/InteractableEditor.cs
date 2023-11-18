using UnityEditor;

[CustomEditor(typeof(Interacable),true)]
public class InteractableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interacable interacable = (Interacable)target;
        if(target.GetType() == typeof(EventOnlyInteractable))
        {
            interacable.promptMessage = EditorGUILayout.TextField("Prompt Message", interacable.promptMessage);
            EditorGUILayout.HelpBox("EventOnlyInteract can ONLY use Unity Event.", MessageType.Info);
            if(interacable.GetComponent<interactionEvent>() ==  null)
            {
                interacable.useEvent = true;
                interacable.gameObject.AddComponent<interactionEvent>();
            }
        }
        else{
            base.OnInspectorGUI();
            if(interacable.useEvent)
            {
                if(interacable.GetComponent<interactionEvent>() == null)
                    interacable.gameObject.AddComponent<interactionEvent>();
            }
            else
            {
                if(interacable.GetComponent<interactionEvent>() != null)
                    DestroyImmediate(interacable.GetComponent<interactionEvent>());
            }
        }
    }
}
