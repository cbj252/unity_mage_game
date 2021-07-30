using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class HelpNavigation : MonoBehaviour
{
    public GameObject Basic;
    public GameObject Controls;
    public GameObject Fire;
    public GameObject Water;
    public GameObject Earth;
    public GameObject Light;
    public ScrollRect scrollView;

    void closeAll()
    {
        Basic.SetActive(false);
        Controls.SetActive(false);
        Fire.SetActive(false);
        Water.SetActive(false);
        Earth.SetActive(false);
        Light.SetActive(false);
    }

    public void showBasic()
    {
        closeAll();
        Basic.SetActive(true);
        scrollView.content = Basic.GetComponent<RectTransform>();
    }

    public void showControls()
    {
        closeAll();
        Controls.SetActive(true);
        scrollView.content = Controls.GetComponent<RectTransform>();
    }

    public void showFire()
    {
        closeAll();
        Fire.SetActive(true);
        scrollView.content = Fire.GetComponent<RectTransform>();
    }

    public void showWater()
    {
        closeAll();
        Water.SetActive(true);
        scrollView.content = Water.GetComponent<RectTransform>();
    }

    public void showEarth()
    {
        closeAll();
        Earth.SetActive(true);
        scrollView.content = Earth.GetComponent<RectTransform>();
    }

    public void showLight()
    {
        closeAll();
        Light.SetActive(true);
        scrollView.content = Light.GetComponent<RectTransform>();
    }

    public void mainReturn()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

}
