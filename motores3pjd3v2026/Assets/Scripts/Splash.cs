using UnityEngine;

public class Splash : MonoBehaviour
{
    void Start()
    {
        // Espera 2 segundos e chama a função
        Invoke("IrParaMenu", 2f);
    }

    void IrParaMenu()
    {
        // Muda o estado
        GameManager.Instance.MudarEstado(GameState.MenuPrincipal);

        // Troca de cena usando o GameManager
        GameManager.Instance.CarregarCena("MenuPrincipal");
    }
}