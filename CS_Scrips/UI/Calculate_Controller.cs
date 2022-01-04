using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Calculate_Controller : MonoBehaviour
{
    public static Calculate_Controller calculate;


    [SerializeField]
    public RectTransform[,] Elementos = new RectTransform[4, 4];
    [SerializeField]
    public elemento[] celdas;
    public GameObject Mi_texto_Matriz;
    public LinkedList<elemento> celda ;


    public int Fila = 0;
    public int Columna = 0;

    public byte Celdas_activas;

    private void Awake()
    {
        Inicialar();
    }
    public void Inicialar()
    {
        Calculate_Controller.calculate = this;
        Organize_Array();
        Application.targetFrameRate = 60;
        print("despiero");

        
    }
    public virtual void Update()
    {

        Limites();
    }
    private void Organize_Array()
    {
        RectTransform[] children = Mi_texto_Matriz.GetComponentsInChildren<RectTransform>();
        elemento[] current =  Mi_texto_Matriz.GetComponentsInChildren<elemento>();

        int indice = 1;

        for (int i = 0; i < 4; i++)
        {
            for (int I = 0; I < 4; I++)
            {
                //LinkedListNode<elemento> current = new LinkedListNode<elemento>(pp[indice]);
                Elementos[i, I] = children[indice];
                celda.AddLast(current[indice]);
                indice++;
            }
        }

        foreach (var celdas in Elementos)
        {
            celda.AddLast(celdas.gameObject.GetComponent<elemento>());
            //print(celda.Find())
        }

    }
    public void Activa_Elemento()
    {
        Elementos[Fila, Columna].GetComponent<elemento>().Is_Active = true;
    }
    public elemento Elemento_Actual()
    {
        Limites();
        return Elementos[Fila, Columna].GetComponent<elemento>();
    }
    public void Limites()
    {
        Columna = Mathf.Clamp(Columna, 0, 3);
        Fila = Mathf.Clamp(Fila, 0, 3);
    }
    /// <summary>
    /// los numeros representa el tipo de matriz
    /// </summary>
    public string Kind_of_matriz;
    public void Comprueba_Matriz()
    {
        //primero comprueba el 2x2
        
    }
    /// <summary>
    /// pasa el numero a negativo
    /// </summary>
    /// 
    public void Pasa_negativo()
    {
        Elemento_Actual().Numero.text = (-1 * (int.Parse(Elemento_Actual().Numero.text))).ToString();
    }
    public void Resert_ELement_actual()
    {
        Elemento_Actual().Resetear();
    }

    public float time = 1;
    public float Pos_y, Pos_x, scale_x, scale_Y;
    public void Empieza_ocultar_matriz()
    {
        StartCoroutine(POS_Y());
        StartCoroutine(POS_X());
        StartCoroutine(Scale());
    }
    IEnumerator POS_Y()
    {

        Pos_y = Mi_texto_Matriz.GetComponent<RectTransform>().localPosition.y;

        while (Mi_texto_Matriz.GetComponent<RectTransform>().localPosition.y < 460)
        {
            Pos_y += (460 / time) * Time.deltaTime;
            Pos_y = Mathf.Clamp(Pos_y, 0, 460);
            Mi_texto_Matriz.GetComponent<RectTransform>().localPosition = new Vector2(Pos_x, Pos_y);

            yield return null;
        }
    }
    IEnumerator POS_X()
    {

        Pos_x = Mi_texto_Matriz.GetComponent<RectTransform>().localPosition.x;

        while (Mi_texto_Matriz.GetComponent<RectTransform>().localPosition.x > -250)
        {
            Pos_x += (-250 / time) * Time.deltaTime;
            Pos_x = Mathf.Clamp(Pos_x, -260, 0);
            Mi_texto_Matriz.GetComponent<RectTransform>().localPosition = new Vector2(Pos_x, Pos_y);

            yield return null;
        }



    }
    IEnumerator Scale()
    {
        scale_x = Mi_texto_Matriz.GetComponent<RectTransform>().localScale.x;

        while (scale_x > 0.3f)
        {
            scale_x -= (0.7f / time) * Time.deltaTime;
            scale_x = Mathf.Clamp(scale_x, 0.3f, 1);
            Mi_texto_Matriz.GetComponent<RectTransform>().localScale = new Vector2(scale_x, scale_x);

            yield return null;
        }
    }

}