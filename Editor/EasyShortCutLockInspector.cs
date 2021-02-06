namespace EasyShortCutLockInspector.Editor
{
    using UnityEditor;
    using UnityEngine;

    internal class EasyShortCutLockInspector : MonoBehaviour
    {
        [MenuItem("Edit/Toggle Inspector Lock %l")]
        public static void Lock ()
        {
            ActiveEditorTracker.sharedTracker.isLocked = ! ActiveEditorTracker.sharedTracker.isLocked;
            ActiveEditorTracker.sharedTracker.ForceRebuild ();
        }

        [MenuItem("Edit/Toggle Inspector Lock %l", true)]
        public static bool Valid ()
        {
            return ActiveEditorTracker.sharedTracker.activeEditors.Length != 0;
        }
    }
}