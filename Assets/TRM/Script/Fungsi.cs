using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.UI;

public class Fungsi : MonoBehaviour
{
    //header
    [Header("Pantai")]
    public Camera cameraPantai;
    public GameObject Air;
    public Material materialAirBersih;
    public Material materialAirKotor;

    public GameObject Bom;


    public GameObject Character;

    //header
    [Header("Pabrik")]

    public Camera cameraPabrik;
    //particle asap
    public ParticleSystem cerobongAsap1;
    public ParticleSystem cerobongAsap2;
    

    [Header("Kota")]
    public Camera cameraKota;
    // header mobil
    [Header("Mobil")]
    public GameObject MobilAsep;
    public GameObject MobilListrik;

    //header sampah
    [Header("Sampah")]
    public GameObject Sampah;

    [Header("ReboisasiKota")]
    public GameObject PohonKota; //default true


    [Header("Sawah")]
    public Camera cameraSawah;
    public GameObject Tanah;
    public GameObject PadiSehat;
    public Material tanahSubur;

    [Header("Pupuk Kimia")]
    public GameObject PadiSakit;
    public Material tanahgersang;

    [Header("Hutan")]
    public Camera cameraHutan;
    public GameObject PohonHutan;




    


    void Start()
    {
        //particle asap start color
        cerobongAsap1.GetComponent<ParticleSystem>();
        cerobongAsap2.GetComponent<ParticleSystem>();
        //anim play pohonkota growth
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GantiCameraPantai()
    {
        cameraPantai.gameObject.SetActive(true);
        cameraPabrik.gameObject.SetActive(false);
        cameraKota.gameObject.SetActive(false);
        cameraSawah.gameObject.SetActive(false);
        cameraHutan.gameObject.SetActive(false);
    }

    public void GantiCameraPabrik()
    {
        cameraPantai.gameObject.SetActive(false);
        cameraPabrik.gameObject.SetActive(true);
        cameraKota.gameObject.SetActive(false);
        cameraSawah.gameObject.SetActive(false);
        cameraHutan.gameObject.SetActive(false);
    }

    public void GantiCameraKota()
    {
        cameraPantai.gameObject.SetActive(false);
        cameraPabrik.gameObject.SetActive(false);
        cameraKota.gameObject.SetActive(true);
        cameraSawah.gameObject.SetActive(false);
        cameraHutan.gameObject.SetActive(false);
    }

    public void GantiCameraSawah()
    {
        cameraPantai.gameObject.SetActive(false);
        cameraPabrik.gameObject.SetActive(false);
        cameraKota.gameObject.SetActive(false);
        cameraSawah.gameObject.SetActive(true);
        cameraHutan.gameObject.SetActive(false);
    }

    public void GantiCameraHutan()
    {
        cameraPantai.gameObject.SetActive(false);
        cameraPabrik.gameObject.SetActive(false);
        cameraKota.gameObject.SetActive(false);
        cameraSawah.gameObject.SetActive(false);
        cameraHutan.gameObject.SetActive(true);
    }
    


    public void GantiWarnaAirBersih()
    {
        Air.GetComponent<Renderer>().material = materialAirBersih;
    }

    public void GantiWarnaAirKotor()
    {
        Air.GetComponent<Renderer>().material = materialAirKotor;
    }

    public void AsapBersih()
    {
        var main = cerobongAsap1.main;
        var main2 = cerobongAsap2.main;

        // Set the start color to a new color (e.g., red)
        main.startColor = Color.white;
        main2.startColor = Color.white;
    }

    public void AsapKotor()
    {
        var main = cerobongAsap1.main;
        var main2 = cerobongAsap2.main;

        // Set the start color to a new color (e.g., red)
        main.startColor = Color.black;
        main2.startColor = Color.black;
    }

    public void MobilBerasap()
    {
        MobilAsep.SetActive(true);
        MobilListrik.SetActive(false);
    }

    public void MobilBerListrik()
    {
        MobilAsep.SetActive(false);
        MobilListrik.SetActive(true);
    }

    public void SampahJatuh(){
        Sampah.SetActive(true);
        if (Sampah.activeSelf == true)
        {
            Sampah.GetComponent<Animator>().SetTrigger("Jatuh");
        }
    }

    public void PohonTumbuh(){
        //set anim trigger pohon tumbuh
        PohonKota.GetComponent<Animator>().SetTrigger("Tumbuh");
    }


    public void PupukKimia()
    {
        PadiSehat.SetActive(false);
        PadiSakit.SetActive(true);
        Tanah.GetComponent<Renderer>().material = tanahgersang;
    }

    public void PadiTumbuh()
    {
        PadiSehat.SetActive(true);
        if (PadiSehat.activeSelf == true)
        {
            PadiSehat.GetComponent<Animator>().SetTrigger("Tumbuh");
        }
        PadiSakit.SetActive(false);
        Tanah.GetComponent<Renderer>().material = tanahSubur;
    }

    public void PohonHutanTebang()
    {
        PohonHutan.GetComponent<Animator>().SetTrigger("Tebang");
    }

    public void PohonHutanTumbuh()
    {
        PohonHutan.GetComponent<Animator>().SetTrigger("Tumbuh");
    }


    public void AnimMelempar()
    {
        Character.GetComponent<Animator>().SetTrigger("Melempar");
        Bom.SetActive(true);
        Bom.GetComponent<Animator>().SetTrigger("Jatuh");
        //delay 2 detik bagaimana
        // Bom.SetActive(false);
    }

    public void AnimMancing()
    {
        Character.GetComponent<Animator>().SetTrigger("Mancing");
    }
}
