using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableBase : MonoBehaviour
{
    public string compareTag = "Player";
    public ParticleSystem particleSys;
    public int timeToHide = 2;
    public GameObject itemGraphic;

    [Header("Sounds")]
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(compareTag))
        {
            Collect();
        }
    }

    protected virtual void Collect()
    {
        if (itemGraphic != null)
        {
            itemGraphic.SetActive(false);
        }
        Invoke("HideObject", timeToHide);
        OnCollect();
    }

    private void HideObject()
    {
        gameObject.SetActive(false);
    }

    protected virtual void OnCollect()
    {
        if(particleSys != null)
        {
            particleSys.Play();
        }
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
