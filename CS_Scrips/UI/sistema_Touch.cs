using UnityEngine;


public class sistema_Touch : MonoBehaviour
{
    private Vector2 inicio;
    private Vector2 final;
    private Touch Mi_Touche;

    private int Fila;
    private int Columna;

    public Guia guia;

    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Mi_Touche = Input.GetTouch(0);

            inicio = Mi_Touche.phase == TouchPhase.Began ? Mi_Touche.position : inicio;

            final = Mi_Touche.phase == TouchPhase.Ended ? Mi_Touche.position : final;

            Fila = inicio.y < final.y ? 1 : 2;
            Columna = inicio.x < final.x ? 1 : 2;

            print(Columna + " " + Fila);

            if (Mi_Touche.phase == TouchPhase.Ended)
            {
                switch (Fila)
                {
                    case 2:
                        guia.Down();
                        break;
                    case 1:
                        guia.Up();
                        break;
                }

                switch (Columna)
                {
                    case 2:
                        guia.Left();
                        break;
                    case 1:
                        guia.Rigth();
                        break;
                }
            }


        }



    }


}

