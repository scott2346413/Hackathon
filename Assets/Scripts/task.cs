using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Task", fileName = "New Task")]
public class task : ScriptableObject
{
    public enum TaskType
    {
        DestroyObject,
        ActivateObject
    }

    public TaskType type;
    public string taskName;
    public string objectsTag;
}
