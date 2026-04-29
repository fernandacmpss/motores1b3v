using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Iniciando,
    MenuPrincipal,
    Gameplay
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState estadoAtual;

    private void Awake()
    {
        // Singleton
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // Começa no estado inicial e vai pra Splash
        MudarEstado(GameState.Iniciando);
        CarregarCena("Splash");
    }

    public void MudarEstado(GameState novoEstado)
    {
        estadoAtual = novoEstado;
        Debug.Log("Estado atual: " + estadoAtual);
    }

    public void CarregarCena(string nomeCena)
    {
        Debug.Log("Carregando cena: " + nomeCena);
        SceneManager.LoadScene(nomeCena);
    }

    public void IniciarJogo()
    {
        MudarEstado(GameState.Gameplay);
        CarregarCena("GetStarted_Scene");
    }

    public void IrParaMenu()
    {
        MudarEstado(GameState.MenuPrincipal);
        CarregarCena("MenuPrincipal");
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}