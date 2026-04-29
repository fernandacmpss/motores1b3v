using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    public void BotaoIniciar()
    {
        GameManager.Instance.IniciarJogo();
    }

    public void BotaoSair()
    {
        GameManager.Instance.SairJogo();
    }
}