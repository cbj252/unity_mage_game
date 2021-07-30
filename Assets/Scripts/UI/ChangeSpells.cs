using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class ChangeSpells : MonoBehaviour
{
    public string player_1_E1;
    public string player_1_E2;
    public string player_2_E1;
    public string player_2_E2;
    public GameObject player_1;
    public GameObject player_2;
    public GameObject mainGameManager;
    public GameObject Fire_1;
    public GameObject Fire_2;
    public GameObject Water_1;
    public GameObject Water_2;
    public GameObject Earth_1;
    public GameObject Earth_2;
    public GameObject Light_1;
    public GameObject Light_2;

    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void changeSpells_p1(string element)
    {
        if (player_1_E1 == element)
        {
            player_1_E1 = "";
        }
        else if (player_1_E2 == element)
        {
            player_1_E2 = "";
        }
        else if (player_1_E1 == "")
        {
            player_1_E1 = element;
        }
        else if (player_1_E2 == "")
        {
            player_1_E2 = element;
        }
    }

    public void changeSpells_p2(string element)
    {
        if (player_2_E1 == element)
        {
            player_2_E1 = "";
        }
        else if (player_2_E2 == element)
        {
            player_2_E2 = "";
        }
        else if (player_2_E1 == "")
        {
            player_2_E1 = element;
        }
        else if (player_2_E2 == "")
        {
            player_2_E2 = element;
        }
    }

    public void startGame()
    {
        if (player_1_E1 != "" && player_1_E2 != "" && player_2_E1 != "" && player_2_E2 != "")
        {
            DontDestroyOnLoad(this.gameObject);
            SceneManager.LoadSceneAsync("MainGame");
        }
    }

    public void mainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player_1 = GameObject.FindWithTag("Player");
        player_2 = GameObject.FindWithTag("Player2");

        # region Spell Selection

        if (player_1_E1 == "Fire")
        {
            player_1.GetComponent<Cast>().spell_1 = Fire_1;
            player_1.GetComponent<Cast>().spell_2 = Fire_2;
        }

        if (player_1_E1 == "Water")
        {
            player_1.GetComponent<Cast>().spell_1 = Water_1;
            player_1.GetComponent<Cast>().spell_2 = Water_2;
        }

        if (player_1_E1 == "Earth")
        {
            player_1.GetComponent<Cast>().spell_1 = Earth_1;
            player_1.GetComponent<Cast>().spell_2 = Earth_2;
        }

        if (player_1_E1 == "Light")
        {
            player_1.GetComponent<Cast>().spell_1 = Light_1;
            player_1.GetComponent<Cast>().spell_2 = Light_2;
        }

        if (player_2_E1 == "Fire")
        {
            player_2.GetComponent<Cast>().spell_1 = Fire_1;
            player_2.GetComponent<Cast>().spell_2 = Fire_2;
        }

        if (player_2_E1 == "Water")
        {
            player_2.GetComponent<Cast>().spell_1 = Water_1;
            player_2.GetComponent<Cast>().spell_2 = Water_2;
        }

        if (player_2_E1 == "Earth")
        {
            player_2.GetComponent<Cast>().spell_1 = Earth_1;
            player_2.GetComponent<Cast>().spell_2 = Earth_2;
        }

        if (player_2_E1 == "Light")
        {
            player_2.GetComponent<Cast>().spell_1 = Light_1;
            player_2.GetComponent<Cast>().spell_2 = Light_2;
        }

        if (player_1_E2 == "Fire")
        {
            player_1.GetComponent<Cast>().spell_3 = Fire_1;
            player_1.GetComponent<Cast>().spell_4 = Fire_2;
        }

        if (player_1_E2 == "Water")
        {
            player_1.GetComponent<Cast>().spell_3 = Water_1;
            player_1.GetComponent<Cast>().spell_4 = Water_2;
        }

        if (player_1_E2 == "Earth")
        {
            player_1.GetComponent<Cast>().spell_3 = Earth_1;
            player_1.GetComponent<Cast>().spell_4 = Earth_2;
        }

        if (player_1_E2 == "Light")
        {
            player_1.GetComponent<Cast>().spell_3 = Light_1;
            player_1.GetComponent<Cast>().spell_4 = Light_2;
        }

        if (player_2_E2 == "Fire")
        {
            player_2.GetComponent<Cast>().spell_3 = Fire_1;
            player_2.GetComponent<Cast>().spell_4 = Fire_2;
        }

        if (player_2_E2 == "Water")
        {
            player_2.GetComponent<Cast>().spell_3 = Water_1;
            player_2.GetComponent<Cast>().spell_4 = Water_2;
        }

        if (player_2_E2 == "Earth")
        {
            player_2.GetComponent<Cast>().spell_3 = Earth_1;
            player_2.GetComponent<Cast>().spell_4 = Earth_2;
        }

        if (player_2_E2 == "Light")
        {
            player_2.GetComponent<Cast>().spell_3 = Light_1;
            player_2.GetComponent<Cast>().spell_4 = Light_2;
        }

        #endregion
    }
}
