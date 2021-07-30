using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowElements : MonoBehaviour
{
    public GameObject GameManager;
    public TextMeshProUGUI player_1_E1_UI;
    public TextMeshProUGUI player_1_E2_UI;
    public TextMeshProUGUI player_2_E1_UI;
    public TextMeshProUGUI player_2_E2_UI;

    // Update is called once per frame
    void Update()
    {
        player_1_E1_UI.text = GameManager.GetComponent<ChangeSpells>().player_1_E1;
        player_1_E2_UI.text = GameManager.GetComponent<ChangeSpells>().player_1_E2;
        player_2_E1_UI.text = GameManager.GetComponent<ChangeSpells>().player_2_E1;
        player_2_E2_UI.text = GameManager.GetComponent<ChangeSpells>().player_2_E2;
    }
}
