using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AFrameGrabbable : MonoBehaviour
{
    public XRGrabInteractable interactable;

    Vector3 interactableDefaultPosition;
    Quaternion interactableDefaultRotation;

    public GameObject audio;

    private void Start()
    {
        interactableDefaultPosition = interactable.transform.localPosition;
        interactableDefaultRotation = interactable.transform.localRotation;
    }

    private void Update()
    {
        audio.SetActive(interactable.isSelected);

        Quaternion rotation = Quaternion.LookRotation(transform.position - interactable.transform.position);
        rotation = Quaternion.Euler(0, Mathf.Clamp(rotation.eulerAngles.y, 90, 270), 0);
        transform.rotation = rotation;

        if (!interactable.isSelected)
        {
            Debug.Log("ResetPos");
            interactable.transform.localPosition = interactableDefaultPosition;
            interactable.transform.localRotation = interactableDefaultRotation;
        }
    }
}
