using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOESelfBase : Initialize
{
    public BoxCollider2D SpellCollider;
    public BoxCollider2D OpponentCollider;
    public int dmg;
    public float tick_time;
    public Color Inactive;
    public Color Active;
    public SpriteRenderer Render;

    public void Cast()
    {
        Render = GetComponent<SpriteRenderer>();
        OpponentCollider = Opponent.GetComponent<BoxCollider2D>();
        Render.color = Inactive;
        StartCoroutine(Spell());
    }

    public IEnumerator Spell()
    {
        yield return new WaitForSecondsRealtime(tick_time - 0.2f);
        Render.color = Active;
        yield return new WaitForSecondsRealtime(0.2f);
        if (SpellCollider.IsTouching(OpponentCollider))
        {
            AudioSource.PlayClipAtPoint(Hit, new Vector3(0, 0, 0));
            Opponent.GetComponent<Status>().Health -= dmg;
        }
        gameObject.SetActive(false);
        yield return null;
    }

    void Update()
    {
        transform.position = Caster.transform.position;
    }
}
