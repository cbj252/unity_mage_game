using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightProjectile : ProjectileBase
{
    private int lightResource;

    void Awake()
    {
        lightResource = Caster.GetComponent<Resource>().lightResource;

        if (lightResource < 5)
        {
            lightResource += 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Opponent)
        {
            AudioSource.PlayClipAtPoint(Hit, new Vector3(0, 0, 0));
            Opponent.GetComponent<Status>().Health -= dmg;
            if (Opponent.GetComponent<Status>().silenceTime > 0)
            {
                Opponent.GetComponent<Status>().rootTime = silenceTime - (0.3 * lightResource);
            }
            else
            {
                Opponent.GetComponent<Status>().silenceTime = silenceTime - (0.3 * lightResource);
            }
            gameObject.SetActive(false);
        }
    }
}
