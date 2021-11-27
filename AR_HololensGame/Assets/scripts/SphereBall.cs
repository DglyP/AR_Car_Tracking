using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereBall : MonoBehaviour
{
    private AudioSource success;
    private AudioSource error;
    private Vector3 scaleChange = new Vector3(-0.005f, -0.005f, -0.005f);
    private bool pop = false;
    private bool blocked = true;
    private int numero;
    
    void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();
        success = sources[0];
        error = sources[1];
    }

    void Update()
    {
        if (pop)
        {
            if (transform.localScale.x > 0.2f) {
                Debug.Log("B");
                transform.localScale += scaleChange;
            } else {
                Debug.Log("A");
                this.transform.parent.GetComponent<GeneralController>().popBubble(numero);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TW");
        if (blocked)
        {
            error.Play();
            Debug.Log("No");
        } else
        {
            Debug.Log("Si");
            if (!pop)
            {
                success.Play();
                pop = true;
            }
        }

    }


    public void setValue(int num)
    {
        GameObject child = this.gameObject.transform.GetChild(0).gameObject;
        TextMeshPro textmeshPro = child.GetComponent<TextMeshPro>();
        numero = num;
        textmeshPro.SetText("" + numero);
    }


    public void activate()
    {
        blocked = false;
    }


}
