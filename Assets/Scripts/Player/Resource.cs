using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resource : MonoBehaviour
{
    private string resource1;
    private string resource2;
    public TextMeshProUGUI resource1_text;
    public TextMeshProUGUI resource2_text;
    public float fireResource;
    public string fireState;
    public int earthResource;
    public double earthTime;
    public int lightResource;
    public double lightTime;

    void Start()
    {
        resource1 = gameObject.GetComponent<Cast>().spell_1.GetComponent<Initialize>().resource;
        resource2 = gameObject.GetComponent<Cast>().spell_3.GetComponent<Initialize>().resource;
        fireState = "Ready";
    }

    public bool hasResource(string resource, float resource_needed)
    {
        #region Fire

        if (resource == "Fire")
        {
            if (fireState == "Ready")
            {
                fireResource = 4f;
                fireState = "Heating";
                return true;
            }
            else if (fireState == "Heating")
            {
                return true;
            }
            else if (fireState == "Cooldown")
            {
                return false;
            }
            else
            {
                Debug.Log("Ilegal firestate");
                return false;
            }
        }

        #endregion

        #region Water

        if (resource == "Water")
        {
            return true;
        }

        #endregion

        #region Earth

        if (resource == "Earth")
        {
            if (earthResource >= (int) resource_needed)
            {
                earthResource -= (int) resource_needed;
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Light

        if (resource == "Light")
        {
            if (lightResource < 5)
            {
                lightResource += (int) resource_needed;
                return true;
            }
            else
            {
                gameObject.GetComponent<Status>().Health -= 1;
                return true;
            }
        }

        #endregion

        Debug.Log("Resource not found.");
        return false;
    }

    void Update()
    {
        #region Fire

        if (fireState == "Heating")
        {
            if (fireResource > 0)
            {
                fireResource -= Time.deltaTime;
            }
            else if (fireResource < 0)
            {
                fireState = "Cooldown";
            }
        }

        if (fireState == "Cooldown")
        {
            if (fireResource < 4)
            {
                fireResource += Time.deltaTime;
            }
            else if (fireResource >= 4)
            {
                fireResource = 4f;
                fireState = "Ready";
            }
        }

        #endregion

        #region Earth

        if (earthResource < 10)
        {
            earthTime += Time.deltaTime;
        }

        if (earthTime > 1.5 && earthResource < 10)
        {
            earthResource += 1;
            earthTime = 0.5f;
        }

        #endregion

        #region Light

        if (lightResource > 0)
        {
            lightTime -= Time.deltaTime;
        }

        if (lightTime < 0)
        {
            lightResource = 0;
            lightTime = 5;
        }

        #endregion
    }
}
