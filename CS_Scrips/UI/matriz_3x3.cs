using UnityEngine;
using UnityEngine.UI;

public class matriz_3x3 : MonoBehaviour
{

    public int n00, n01, n02,
               n10, n11, n12,
               n20, n21, n22;

    
    public int determinante
    {
        get => _determinante; 
    }
    private int _determinante;

    private void Start()
    {
        _determinante = Determinar();
        
    }
    public int Determinar()
    {

  
        var diagonal_Principal = n00 * n11 * n22;
        diagonal_Principal += n10 * n21 * n02;
        diagonal_Principal += n20 * n01 * n12;

        var diagonal_Secundaria = n02 * n11;

        return 0;
    }
    /// <summary>
    /// use this to transport the principal matriz 
    /// </summary>
    /// <returns>a list (t[]) </returns>
    /// <example>
    /// <code>
    /// var My_Matriz = Transponer();
    /// </code> 
    /// </example>
    public int[] Transponer()
    {
        int[] t = {n00,n10,n20,
                   n01,n11,n21,
                   n02,n12,n22 };

        return t;
    }
    

}
