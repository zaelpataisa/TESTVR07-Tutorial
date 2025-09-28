using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableGrabbingHandModel : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject RightHandModel;

    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(HideGrabbingHand);
            grabInteractable.selectExited.AddListener(ShowGrabingHGand);
        }
    }

    private void HideGrabbingHand(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(false);
        }
        else if (args.interactorObject.transform.tag == "Right Hand")
        {
            RightHandModel.SetActive(false);
        }
    }
    private void ShowGrabingHGand(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "Right Hand")
        {
            RightHandModel.SetActive(true);
        }
    }
}
