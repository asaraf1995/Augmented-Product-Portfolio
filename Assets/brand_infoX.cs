using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class brand_infoX : MonoBehaviour
{

    public GameObject vbBtnObj;
    public GameObject brandquad;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("brandinfoX");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        brandquad = GameObject.Find("brandquadX");
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