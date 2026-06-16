using UnityEngine;

public class Splash : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(IrParaMenu), 2f);
    }

    void IrParaMenu()
    {
        GameManager.Instance.IrParaMenu();
    }
}