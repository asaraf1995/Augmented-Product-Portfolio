using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class view_reviewX : MonoBehaviour
{

    public GameObject vbBtnObj;
    public GameObject viewReviewQuad;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("View ReviewsX");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        viewReviewQuad = GameObject.Find("viewreviewquadX");
        viewReviewQuad.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        viewReviewQuad.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        viewReviewQuad.SetActive(false);
    }
}