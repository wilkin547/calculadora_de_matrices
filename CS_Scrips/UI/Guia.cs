using UnityEngine;

public class Guia : MonoBehaviour
{

    private int fila = 0;
    private int Columna = 0;
    [SerializeField]
    private RectTransform transform;
    



    public void Up()
    {
        print("arriba");
        limite();
        fila -= 1;
        Calculate_Controller.calculate.Fila = fila;
        limite();
        Actualiza_posicion();
    }

    public void Down()
    {
        print("abajo");
        limite();
        fila += 1;
        Calculate_Controller.calculate.Fila = fila;
        limite();
        Actualiza_posicion();
    }

    public void Rigth()
    {
        print("derecha");
        limite();
        Columna += 1;
        Calculate_Controller.calculate.Columna = Columna;
        limite();
        Actualiza_posicion();

    }

    public void Left()
    {
        print("izquierda");
        limite();
        Columna -= 1;
        Calculate_Controller.calculate.Columna = Columna;
        limite();
        Actualiza_posicion();
      
    }

    private void limite()
    {
        fila = Mathf.Clamp(fila, 0, 3);
        Columna = Mathf.Clamp(Columna, 0, 3);
    }

    private elemento Ultimo_elemento = new elemento();

    public void Actualiza_posicion()
    {
        //cada elemento tiene su posicion especial , llamada guia , asi puedo modificarlo facilmente   // :v , si es un lio 

        if (!Calculate_Controller.calculate.Elemento_Actual().used)
        {
            Ultimo_elemento.Is_Active = false;
        }
        else
        {
            Calculate_Controller.calculate.Elemento_Actual().Is_Active = true;
        }

        transform.position = Calculate_Controller.calculate.Elementos[fila, Columna].GetComponent<elemento>().guia.position;

        Ultimo_elemento = Calculate_Controller.calculate.Elemento_Actual(); 

        Calculate_Controller.calculate.Elemento_Actual().Is_Active = true;

        print($"{fila} y {Columna}" );
    }
}
