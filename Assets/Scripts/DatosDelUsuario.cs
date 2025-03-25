using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    //Dos formas de acceder a las variables desde el inspector
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    public float estatura;
    public bool donaOrganos;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario + ", tengo " + edadUsuario + ", mido " + estatura + " metros y es " + donaOrganos + " que soy donante de órganos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
