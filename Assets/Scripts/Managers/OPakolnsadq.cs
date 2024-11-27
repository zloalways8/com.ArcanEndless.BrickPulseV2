using UnityEngine;
using UnityEngine.Serialization;

namespace Managers
{
    public class OPakolnsadq : MonoBehaviour
    {
        private const string WKnlverlkq1 = "Popwpqomvcop";
        private const string Poqwpjvopir4 = "BNkjansljdq";

        [FormerlySerializedAs("backgroundMusic")] [SerializeField] private AudioSource Bmaklsq;
        [FormerlySerializedAs("buttonClick")] [SerializeField] private AudioSource Wopvjmret;
        [FormerlySerializedAs("winSound")] [SerializeField] private AudioSource QXSvreqwe;
        [FormerlySerializedAs("loseSound")] [SerializeField] private AudioSource Wnvlkrtel;
        [FormerlySerializedAs("damageSound")] [SerializeField] private AudioSource WQKnlvktrlqllknml;
        
        public bool WNkvnanlkslk { get; set; }

        public bool CNMKLrlk45
        {
            get => Bmaklsq.mute;
            set => Bmaklsq.mute = value;
        }

        private void Start()
        {
            if (!PlayerPrefs.HasKey(WKnlverlkq1))
                PlayerPrefs.SetInt(WKnlverlkq1, CNMKLrlk45 ? 1 : 0);
            
            if (!PlayerPrefs.HasKey(Poqwpjvopir4))
                PlayerPrefs.SetInt(Poqwpjvopir4, WNkvnanlkslk ? 1 : 0);

            CNMKLrlk45 = PlayerPrefs.GetInt(WKnlverlkq1) == 1;
            WNkvnanlkslk = PlayerPrefs.GetInt(Poqwpjvopir4) == 1;
        }

        public void POjcerwiop34()
        {
            if (WNkvnanlkslk)
                return;
            
            Wopvjmret.Play();
        }

        public void Bnkjaskld2()
        {
            if (WNkvnanlkslk)
                return;
            
            WQKnlvktrlqllknml.Play();
        }

        public void BNjasksldkl6()
        {
            if (WNkvnanlkslk)
                return;

            QXSvreqwe.Play();
        }
        
        public void SAMvlsdf()
        {
            if (WNkvnanlkslk)
                return;

            Wnvlkrtel.Play();
        }

        public void StartBackgroundMelody()
        {
            Bmaklsq.Play();
        }
    }
}