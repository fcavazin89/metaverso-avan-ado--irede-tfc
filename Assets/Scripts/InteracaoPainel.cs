
using UnityEngine;
using UnityEngine.Events;

public class InteracaoPainel : MonoBehaviour
{
    [Header("Configurações Visuais")]
    public Color corInicial = Color.white;
    public Color corHover = Color.yellow;
    public Color corAtivado = Color.green;
    
    [Header("Feedback")]
    public AudioClip somFeedback;
    public UnityEvent onInteragir;
    
    private Renderer _renderer;
    private AudioSource _audio;
    private bool _foiInteragido = false;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _audio = gameObject.AddComponent<AudioSource>();
        _audio.clip = somFeedback;
        _audio.playOnAwake = false;
        
        if(_renderer != null) _renderer.material.color = corInicial;
    }

    public void OnHoverEnter()
    {
        if(_foiInteragido) return;
        if(_renderer != null) _renderer.material.color = corHover;
    }

    public void OnHoverExit()
    {
        if(_foiInteragido) return;
        if(_renderer != null) _renderer.material.color = corInicial;
    }

    public void OnSelect()
    {
        if(_foiInteragido) return;
        
        _foiInteragido = true;
        if(_renderer != null) _renderer.material.color = corAtivado;
        if(_audio != null && somFeedback != null) _audio.Play();
        
        onInteragir?.Invoke();
        Debug.Log($"[INTERAÇÃO] {gameObject.name}: Informação exibida!");
    }
}
