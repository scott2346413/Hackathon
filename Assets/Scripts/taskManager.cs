using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class taskManager : MonoBehaviour
{
    public task[] tasks;
    Dictionary<task, GameObject[]> taskObjects = new Dictionary<task, GameObject[]>();

    public TextMeshProUGUI tasksText;

    private void Start()
    {
        foreach (task task in tasks)
        {
            taskObjects[task] = GameObject.FindGameObjectsWithTag(task.objectsTag);
        }
    }

    private void Update()
    {
        string taskProgressText = "";

        foreach (task task in tasks)
        {
            float progress = 0;
            GameObject[] objects = taskObjects[task];

            foreach (GameObject taskObject in objects)
            {
                switch (task.type)
                {
                    case task.TaskType.DestroyObject:
                        if (taskObject == null) progress++;
                        break;
                    case task.TaskType.ActivateObject:
                        if (taskObject.activeInHierarchy == true) progress++;
                        break;
                }
            }

            string taskText = task.name + " [" + progress + "/" + objects.Length + "] \n";
            taskProgressText += taskText;
        }

        tasksText.text = taskProgressText;
    }
}
