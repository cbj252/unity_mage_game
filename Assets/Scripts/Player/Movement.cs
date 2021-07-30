using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Caster;
    float min_Y = -4.5f;
    float max_Y = 4.0f;
    float min_X = -6.25f;
    float max_X = 6.25f;
    public float baseSpeed;
    [HideInInspector] public float speed;
    public bool channelRoot;
    public string VerticalAxis;
    public string HorizontalAxis;

    void Awake()
    {
        speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 0)
        {
            if (Caster.GetComponent<Status>().rootTime == 0)
            {
                if (!(channelRoot == true && Caster.GetComponent<Status>().channelTime > 0))
                {
                    MovePlayer();
                }
            }
        }
    }

    void MovePlayer()
    {
        if (Input.GetAxisRaw(VerticalAxis) > 0f)
        {
            Caster.GetComponent<Resource>().earthTime = 0f;
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;

            if (temp.y > max_Y)
                temp.y = max_Y;

            transform.position = temp;

        }
        else if (Input.GetAxisRaw(VerticalAxis) < 0f)
        {
            Caster.GetComponent<Resource>().earthTime = 0f;
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;

            if (temp.y < min_Y)
                temp.y = min_Y;

            transform.position = temp;
        }
        if (Input.GetAxisRaw(HorizontalAxis) > 0f)
        {
            Caster.GetComponent<Resource>().earthTime = 0f;
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;

            if (temp.x > max_X)
                temp.x = max_X;

            transform.position = temp;

        }
        else if (Input.GetAxisRaw(HorizontalAxis) < 0f)
        {
            Caster.GetComponent<Resource>().earthTime = 0f;
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;

            if (temp.x < min_X)
                temp.x = min_X;

            transform.position = temp;
        }
    }
}
