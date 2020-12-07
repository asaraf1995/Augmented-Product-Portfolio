using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class brandinformation : MonoBehaviour
{

    public GameObject vbBtnObj;
    public GameObject brandquad;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("brandinfo");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        brandquad = GameObject.Find("brandquad");
        brandquad.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        brandquad.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        brandquad.SetActive(false);
    }
}