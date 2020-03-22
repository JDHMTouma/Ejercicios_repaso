using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FrasesMotivacionales : MonoBehaviour
{
    public List<string> Frases;
    float timer;
    public Text Frase;
    int numFrase;
    bool zawarudo;


    // Start is called before the first frame update
    void Start()
    {
        timer = 10f;

        for (int y = 0; y <= 4; y++)
        {
            print(Frases[y]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (zawarudo == false)
        {
            timer -= Time.deltaTime;
            //print(timer);

        }

        Frase.text = Frases[numFrase];

        if (timer < 0)
        {
            if(numFrase < 4)
            {
                numFrase++;
                timer = 10f;
            }
            else
            {
                numFrase = 0;
                timer = 10f;
            }


        }



    }

    public void Randomizer()
    {
        numFrase = Random.Range(0, 4);
    }
    public void StopTime()
    {
        zawarudo = !zawarudo;
    }
}
