using UnityEngine;

[RequireComponent(typeof(AudioClip))]
public class ClientMusicPlayer: Singleton<ClientMusicPlayer>
{
    [SerializeField] private AudioClip nomAudioClip;

    private AudioSource m_AudioSource;

    public override void Awake()
    {
        base.Awake();
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void PlayNomAudioClip()
    {
        m_AudioSource.clip = nomAudioClip;
        m_AudioSource.Play();
    }
}
