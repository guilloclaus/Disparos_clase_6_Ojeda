using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion_player : MonoBehaviour
{

    public GameObject PuntoDisparo;
    public GameObject Bala;
    public float lapsoDisparo = 2.0f;
    private float TiempoRecarga;

    // Start is called before the first frame update
    void Start()
    {
        TiempoRecarga = lapsoDisparo;
    }

    // Update is called once per frame
    void Update()
    {
        TiempoRecarga -= Time.deltaTime;
        if (TiempoRecarga <= 0)
        {
            Disparar();
            TiempoRecarga = lapsoDisparo;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bala.transform.localScale = new Vector3(Bala.transform.localScale.x * 2, Bala.transform.localScale.y * 2, Bala.transform.localScale.z * 2);
            Debug.Log("Se duplica Tamaño de Bala");
        }

    }

    void Disparar()
    {
        Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
        Debug.Log("Disparo!!!");

    }
}
