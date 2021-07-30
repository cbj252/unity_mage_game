using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize : MonoBehaviour
{
    public GameObject Caster;
    public GameObject Opponent;
    public AudioClip Hit;
    public float castTime;
    public double recoveryTime;
    public bool channelRoot;
    public float slowMag;
    public float slowTime;
    public double silenceTime;
    public string resource;
    public float resource_needed;
    private Vector3 originalScale;
    [HideInInspector] public bool fired;

    public void SetCaster(GameObject passed_Caster, GameObject passed_Opponent)
    {
        Caster = passed_Caster;
        Opponent = passed_Opponent;
    }

    public IEnumerator Start()
    {
        if (Caster.GetComponent<Resource>().hasResource(resource, resource_needed))
        {
            if (channelRoot == true)
            {
                Caster.GetComponent<Movement>().channelRoot = true;
            }
            if (channelRoot == false)
            {
                Caster.GetComponent<Movement>().channelRoot = false;
            }
            originalScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(0, 0, 0);
            Caster.GetComponent<Status>().channelTime = castTime;
            Invoke("Cast", castTime);
            yield return new WaitForSecondsRealtime(castTime);
            gameObject.transform.localScale = originalScale;
            fired = true;
            Caster.GetComponent<Status>().silenceTime = recoveryTime;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Caster.GetComponent<Status>().channelSuccess == false)
        {
            CancelInvoke();
            Caster.GetComponent<Status>().channelTime = 0f;
            Caster.GetComponent<Status>().channelSuccess = true;
            gameObject.SetActive(false);
        }
    }

    public void SlowRecover()
    {
        Opponent.GetComponent<Movement>().speed += slowMag;
        gameObject.SetActive(false);
    }
}
