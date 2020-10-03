using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnStep : MonoBehaviour
{
    [SerializeField] float _delay = 3;
    private bool _falling = false;

    void Update()
    {
        if (_falling)
        {
            _delay -= Time.deltaTime;
        }
        if (_delay < 0)
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _falling = true;

        }
        if (collision.gameObject.tag == "FallOffZone")
        {
            Destroy(this.gameObject, 3);
        }
    }
}
