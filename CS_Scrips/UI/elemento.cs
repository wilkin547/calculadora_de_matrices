﻿using UnityEngine;

using TMPro;


public class elemento : MonoBehaviour
{
    [SerializeReference]
    public int Valor;
    public TMP_Text Numero;
    public bool Is_Active;
    [SerializeField]
    private Color activo;
    [SerializeField]
    private Color desactivar;
    /// <summary>
    /// indica si ya se ha usado el elemente
    /// </summary>
    
    public bool used;

    public RectTransform guia;


    private void Awake()
    {
        Numero = GetComponent<TMP_Text>();
        Numero.text = Valor.ToString();

       

    }

    private void Update()
    {
        transparencia();
        Valor = int.Parse(Numero.text);

    }

   public void transparencia()
    {
        if (Is_Active || used)
        {
            //el texto esta mas transparente . Asi se da la ilucion de desactivado
            Numero.faceColor = activo;
            Numero.color = activo;
        }
        else
        {
            Numero.faceColor = desactivar;
            Numero.color = desactivar;
        }
    }


}
