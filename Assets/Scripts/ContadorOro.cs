using UnityEngine;

public class ContadorOro : MonoBehaviour
{
    private int oro = 0;

    private void Cobrar()
    {
        oro += 1;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(40, 40, 200, 40), $"Oro: {oro}");

        if (GUI.Button(new Rect(40, 90, 200, 60), "Cobrar"))
        {
            Cobrar();
        }

        if (GUI.Button(new Rect(40, 170, 200, 60), "Reiniciar"))
        {
            oro = 0;
        }
    }
}