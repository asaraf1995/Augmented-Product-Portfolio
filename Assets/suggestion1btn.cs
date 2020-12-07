using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class suggestion1btn : MonoBehaviour
{

    public GameObject vbBtnObj;
    public GameObject suggestionquad;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("suggestion1");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        suggestionquad = GameObject.Find("suggestionquad1");
        suggestionquad.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        suggestionquad.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        suggestionquad.SetActive(false);
    }
}