﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos;
    float magnitudTerremoto;
    string nombreAlumno;
    bool compuHabilitada;

    // Start is called before the first frame update
    void Start()
    {
        cantidadAlumnos = 25;
        magnitudTerremoto = 9.3f; //especifico que es un float.
        nombreAlumno = "Joaquin";
        compuHabilitada = false;

        Debug.Log(cantidadAlumnos);
        Debug.Log(magnitudTerremoto);
        Debug.Log(nombreAlumno);
        Debug.Log(compuHabilitada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
