using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BorderButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image borderImage; // Referência à imagem da borda

    void Start()
    {
        // Certifique-se de que a borda começa invisível
        SetBorderVisible(false);
    }

    // Método para tornar a borda visível ou invisível
    public void SetBorderVisible(bool isVisible)
    {
        Color borderColor = borderImage.color;
        borderColor.a = isVisible ? 1 : 0; // Se visível, alpha = 1, caso contrário alpha = 0
        borderImage.color = borderColor;
    }

    // Quando o cursor entra no botão
    public void OnPointerEnter(PointerEventData eventData)
    {
        SetBorderVisible(true);
    }

    // Quando o cursor sai do botão
    public void OnPointerExit(PointerEventData eventData)
    {
        SetBorderVisible(false);
    }
}
