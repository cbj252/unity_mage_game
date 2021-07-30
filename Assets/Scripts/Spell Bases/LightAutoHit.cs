using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAutoHit : Initialize
{
    private int lightResource;
    public SpriteRenderer Render;
    public int dmg;
    public Color Inactive;
    public Color Active;
    private float channelTime;

    void Awake()
    {
        lightResource = Caster.GetComponent<Resource>().lightResource;

        if (lightResource < 5)
        {
            lightResource += 1;
        }

        channelTime = (float) (0.5 + (0.3 * lightResource));
    }

    void Cast()
    {
        StartCoroutine(Spell());
    }

    public IEnumerator Spell()
    {
        Caster.GetComponent<Status>().channelTime = channelTime;
        Render.color = Inactive;
        yield return new WaitForSecondsRealtime(channelTime - 0.2f);
        Render.color = Active;
        yield return new WaitForSecondsRealtime(0.2f);

        AudioSource.PlayClipAtPoint(Hit, new Vector3(0, 0, 0));
        Opponent.GetComponent<Status>().Health -= dmg;

        gameObject.SetActive(false);
        yield return null;
    }

    void Update()
    {
        transform.position = Opponent.transform.position;
    }
}
