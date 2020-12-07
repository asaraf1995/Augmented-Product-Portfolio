using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class view_reviews : MonoBehaviour
{

    public GameObject vbBtnObj;
    public GameObject viewReviewQuad;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("View Reviews");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        viewReviewQuad= GameObject.Find("viewreviewquad");
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