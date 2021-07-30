using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : Initialize
{
    private double min_X = -7f;
    private double max_X = 7f;
    private double min_Y = -7f;
    private double max_Y = 7f;
    public int dmg;
    public int missileSpeed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Opponent)
        {
            AudioSource.PlayClipAtPoint(Hit, new Vector3(0, 0, 0));
            Opponent.GetComponent<Status>().Health -= dmg;
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

    public void Cast()
    {
        transform.position = Caster.transform.position;
        Angle();
    }

    void Update()
    {
        if (fired == false && Caster.GetComponent<Status>().channelTime == 0)
        {
            fired = true;
        }
        if (fired == true)
        {
            transform.position += transform.right * Time.deltaTime * missileSpeed;
            if (transform.position.x < min_X | transform.position.x > max_X)
            {
                gameObject.SetActive(false);
            }
            if (transform.position.y < min_Y | transform.position.y > max_Y)
            {
                gameObject.SetActive(false);
            }
        }
    }

    // Written by DMGregory on StackExchange. https://gamedev.stackexchange.com/questions/111718/make-one-object-rotate-to-face-another-object-in-2d
    void Angle()
    {
        Vector3 offset = Opponent.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, offset);
        transform.rotation = rotation * Quaternion.Euler(0, 0, 90);
    }
}