using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bom : MonoBehaviour
{
    public GameObject partikel;
    public ParticleSystem ledakan;
    public GameObject water;
    public Material AirKotor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void meledak()
    {
        partikel.SetActive(true);
        ledakan.Play();
    }

    public void berhentiMeledak()
    {
        partikel.SetActive(false);
        ledakan.Stop();
    }

    public void GantiMaterialAirKotor()
    {
        water.GetComponent<Renderer>().material = AirKotor;   
    }
}
