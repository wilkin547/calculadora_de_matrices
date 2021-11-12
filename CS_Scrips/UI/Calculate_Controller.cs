using System.Collections;
using UnityEngine;

public class Calculate_Controller : MonoBehaviour
{
    public static Calculate_Controller calculate;


    [SerializeField]
    public RectTransform[,] Elementos = new RectTransform[4, 4];
    private elemento[,] celdas;
    public RectTransform Mi_texto_Matriz;

    public int Fila = 0;
    public int Columna = 0;

    private void Awake()
    {
        Organize_Array();
        Calculate_Controller.calculate = this;

    }
    public virtual void Update()
    {
        Application.targetFrameRate = 60;
        limites();
    }
    private void Organize_Array()
    {
        RectTransform[] children = Mi_texto_Matriz.GetComponentsInChildren<RectTransform>();

        int indice = 1;

        for (int i = 0; i < 4; i++)
        {
            for (int I = 0; I < 4; I++)
            {
                Elementos[i, I] = children[indice];
               // celdas[i, I] = Elementos[i, I].GetComponent<elemento>();
                indice++;
            }
        }
        
    }
    public void Activa_Elemento()
    {
        Elementos[Fila, Columna].GetComponent<elemento>().Is_Active = true;
    }
    public void Desactiva_Elemento()
    {
        Elementos[Fila, Columna].GetComponent<elemento>().Is_Active = false;
    }
    public elemento Elemento_Actual()
    {
        limites();
        return Elementos[Fila, Columna].GetComponent<elemento>();
    }
    public void limites()
    {
        Columna = Mathf.Clamp(Columna, 0, 3);
        Fila = Mathf.Clamp(Fila, 0, 3);
    }

    /// <summary>
    /// los numeros representa el tipo de matriz
    /// </summary>
    public bool[] Kind_Of_Matriz;
    public void Comprueba_Matriz()
    {

        var _2x2 = 
            celdas[0, 0].used & celdas[0, 1].used &
            celdas[1, 0].used & celdas[1, 1].used;
        
        var _2x3 = _2x2 &
             celdas[0, 2].used &
             celdas[1, 2].used;

        var _2x4 = _2x3 &
             celdas[0, 3].used &
             celdas[1, 3].used;

        var _3x3 = _2x3 &
            celdas[2, 0].used & celdas[2, 1].used &
            celdas[2, 2].used;

        var _3x4 = _3x3 &
            celdas[0, 3].used &
            celdas[1, 3].used &
            celdas[2, 3].used;


        var _4x4 = _3x4 &
            celdas[3, 0].used & celdas[3, 1].used & celdas[3, 2].used &
            celdas[3, 3].used;
 
        


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

        Pos_y = Mi_texto_Matriz.localPosition.y;

        while (Mi_texto_Matriz.localPosition.y < 460)
        {
            Pos_y += (460 / time) * Time.deltaTime;
            Pos_y = Mathf.Clamp(Pos_y, 0, 460);
            Mi_texto_Matriz.localPosition = new Vector2(Pos_x, Pos_y);

            yield return null;
        }
    }
    IEnumerator POS_X()
    {

        Pos_x = Mi_texto_Matriz.localPosition.x;

        while (Mi_texto_Matriz.localPosition.x > -250)
        {
            Pos_x += (-250 / time) * Time.deltaTime;
            Pos_x = Mathf.Clamp(Pos_x, -260, 0);
            Mi_texto_Matriz.localPosition = new Vector2(Pos_x, Pos_y);

            yield return null;
        }



    }
    IEnumerator Scale()
    {
        scale_x = Mi_texto_Matriz.localScale.x;

        while (scale_x > 0.3f)
        {
            scale_x -= (0.7f / time) * Time.deltaTime;
            scale_x = Mathf.Clamp(scale_x, 0.3f, 1);
            Mi_texto_Matriz.localScale = new Vector2(scale_x, scale_x);

            yield return null;
        }
    }

}