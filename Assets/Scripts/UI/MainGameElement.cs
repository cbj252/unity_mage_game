using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using TMPro;

// Handles text displaying the resources of each player.

public class MainGameElement : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject resetButton;
    public string player_1_E1;
    public string player_1_E2;
    public string player_2_E1;
    public string player_2_E2;
    public string p1_fireState;
    public string p2_fireState;
    public TextMeshProUGUI p1_resource1;
    public TextMeshProUGUI p1_resource2;
    public TextMeshProUGUI p2_resource1;
    public TextMeshProUGUI p2_resource2;
    
    void Start()
    {
        player_1_E1 = player1.GetComponent<Cast>().spell_1.GetComponent<Initialize>().resource;
        player_1_E2 = player1.GetComponent<Cast>().spell_3.GetComponent<Initialize>().resource;
        player_2_E1 = player2.GetComponent<Cast>().spell_1.GetComponent<Initialize>().resource;
        player_2_E2 = player2.GetComponent<Cast>().spell_3.GetComponent<Initialize>().resource;

        #region colour Earth
        if (player_1_E1 == "Earth")
        {
            p1_resource1.color = new Color32(255, 100, 0, 200);
        }
        if (player_1_E2 == "Earth")
        {
            p1_resource2.color = new Color32(255, 100, 0, 200);
        }
        if (player_2_E1 == "Earth")
        {
            p2_resource1.color = new Color32(255, 100, 0, 200);
        }
        if (player_2_E2 == "Earth")
        {
            p2_resource2.color = new Color32(255, 100, 0, 200);
        }
        #endregion

        #region colour Light
        if (player_1_E1 == "Light")
        {
            p1_resource1.color = new Color32(255, 255, 0, 200);
        }
        if (player_1_E2 == "Light")
        {
            p1_resource2.color = new Color32(255, 255, 0, 200);
        }
        if (player_2_E1 == "Light")
        {
            p2_resource1.color = new Color32(255, 255, 0, 200);
        }
        if (player_2_E2 == "Light")
        {
            p2_resource2.color = new Color32(255, 255, 0, 200);
        }
        #endregion
    }

    void Update()
    {
        #region showResources
        p1_fireState = player1.GetComponent<Resource>().fireState;
        p2_fireState = player2.GetComponent<Resource>().fireState;

        if (player_1_E1 == "Fire")
        {
            if (p1_fireState == "Cooldown")
            {
                p1_resource1.color = new Color32(155, 155, 155, 100);
            }
            else
            {
                p1_resource1.color = new Color32(255, 0, 0, 200);
            }
            p1_resource1.text = Math.Round(player1.GetComponent<Resource>().fireResource, 1).ToString();
        }
        else if (player_1_E1 == "Earth")
        {
            p1_resource1.text = player1.GetComponent<Resource>().earthResource.ToString();
        }
        else if (player_1_E1 == "Light")
        {
            p1_resource1.text = player1.GetComponent<Resource>().lightResource.ToString() + "\n" + Math.Round(player1.GetComponent<Resource>().lightTime, 1).ToString();
        }

        if (player_1_E2 == "Fire")
        {
            if (p1_fireState == "Cooldown")
            {
                p1_resource2.color = new Color32(155, 155, 155, 100);
            }
            else
            {
                p1_resource2.color = new Color32(255, 0, 0, 200);
            }
            p1_resource2.text = Math.Round(player1.GetComponent<Resource>().fireResource, 1).ToString();
        }
        else if (player_1_E2 == "Earth")
        {
            p1_resource2.text = player1.GetComponent<Resource>().earthResource.ToString();
        }
        else if (player_1_E2 == "Light")
        {
            p1_resource2.text = player1.GetComponent<Resource>().lightResource.ToString() + "\n" + Math.Round(player1.GetComponent<Resource>().lightTime, 1).ToString();
        }

        if (player_2_E1 == "Fire")
        {
            if (p2_fireState == "Cooldown")
            {
                p2_resource1.color = new Color32(155, 155, 155, 100);
            }
            else
            {
                p2_resource1.color = new Color32(255, 0, 0, 200);
            }
            p2_resource1.text = Math.Round(player2.GetComponent<Resource>().fireResource, 1).ToString();
        }
        else if (player_2_E1 == "Earth")
        {
            p2_resource1.text = player2.GetComponent<Resource>().earthResource.ToString();
        }
        else if (player_2_E1 == "Light")
        {
            p2_resource1.text = player2.GetComponent<Resource>().lightResource.ToString() + "\n" + Math.Round(player2.GetComponent<Resource>().lightTime, 1).ToString();
        }

        if (player_2_E2 == "Fire")
        {
            if (p2_fireState == "Cooldown")
            {
                p2_resource2.color = new Color32(155, 155, 155, 100);
            }
            else
            {
                p2_resource2.color = new Color32(255, 0, 0, 200);
            }
            p2_resource2.text = Math.Round(player2.GetComponent<Resource>().fireResource, 1).ToString();
        }
        else if (player_2_E2 == "Earth")
        {
            p2_resource2.text = player2.GetComponent<Resource>().earthResource.ToString();
        }
        else if (player_2_E2 == "Light")
        {
            p2_resource2.text = player2.GetComponent<Resource>().lightResource.ToString() + "\n" + Math.Round(player2.GetComponent<Resource>().lightTime, 1).ToString();
        }

        #endregion

        #region resetGame

        if (player1.GetComponent<Status>().Health <= 0 | player2.GetComponent<Status>().Health <= 0)
        {
            resetButton.SetActive(true);
        }

        #endregion
    }

    public void resetGame()
    {
        resetButton.SetActive(false);
        SceneManager.LoadSceneAsync("Element Selection");
    }
}
