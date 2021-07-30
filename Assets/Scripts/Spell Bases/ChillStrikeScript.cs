using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChillStrikeScript : ProjectileBase
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Opponent)
        {
            AudioSource.PlayClipAtPoint(Hit, new Vector3(0, 0, 0));
            if (Opponent.GetComponent<Movement>().speed >= Opponent.GetComponent<Movement>().baseSpeed)
            {
                Opponent.GetComponent<Status>().Health -= dmg;
            }
            Opponent.GetComponent<Status>().silenceTime += silenceTime;
            if (slowMag > 0)
            {
                gameObject.transform.localScale = new Vector3(0, 0, 0);
                Opponent.GetComponent<Movement>().speed -= slowMag;
                Invoke("SlowRecover", slowTime);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}
