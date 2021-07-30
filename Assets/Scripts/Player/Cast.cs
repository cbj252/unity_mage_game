using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cast : MonoBehaviour
{
    public GameObject spell_1;
    public GameObject spell_2;
    public GameObject spell_3;
    public GameObject spell_4;
    public KeyCode spellKey_1;
    public KeyCode spellKey_2;
    public KeyCode spellKey_3;
    public KeyCode spellKey_4;
    public GameObject Caster;
    public GameObject Opponent;

    void Update()
    {
        if (Input.GetKeyDown(spellKey_1))
        {
            if (Caster.GetComponent<Status>().silenceTime == 0 && Caster.GetComponent<Status>().channelTime == 0)
            {
                spell_1.GetComponent<Initialize>().SetCaster(Caster, Opponent);
                Instantiate(spell_1, transform.position, Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(spellKey_2))
        {
            if (Caster.GetComponent<Status>().silenceTime == 0 && Caster.GetComponent<Status>().channelTime == 0)
            {
                spell_2.GetComponent<Initialize>().SetCaster(Caster, Opponent);
                Instantiate(spell_2, transform.position, Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(spellKey_3))
        {
            if (Caster.GetComponent<Status>().silenceTime == 0 && Caster.GetComponent<Status>().channelTime == 0)
            {
                spell_3.GetComponent<Initialize>().SetCaster(Caster, Opponent);
                Instantiate(spell_3, transform.position, Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(spellKey_4))
        {
            if (Caster.GetComponent<Status>().silenceTime == 0 && Caster.GetComponent<Status>().channelTime == 0)
            {
                spell_4.GetComponent<Initialize>().SetCaster(Caster, Opponent);
                Instantiate(spell_4, transform.position, Quaternion.identity);
            }
        }
    }
}