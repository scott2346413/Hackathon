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
    bool tasksCompleted = false;

    private void Start()
    {
        foreach (task task in tasks)
        {
            taskObjects[task] = GameObject.FindGameObjectsWithTag(task.objectsTag);
        }
    }

    private void Update()
    {
        bool allTasksCompleted = true;
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

            if(progress != objects.Length)
            {
                allTasksCompleted = false;
            }

            string taskText = task.taskName + " [" + progress + "/" + objects.Length + "] \n";
            taskProgressText += taskText;
        }

        tasksText.text = taskProgressText;
        tasksCompleted = allTasksCompleted;
    }

    public void Finish()
    {
        if (!tasksCompleted)
        {
            return;
        }

        foreach(finishObjectActivator finishObject in FindObjectsOfType<finishObjectActivator>())
        {
            finishObject.Activate();
        }
    }
}
