using Content;
using Managers;
using UI;
using UnityEngine;
using UnityEngine.Serialization;

public class ASKNldkfwenklb : MonoBehaviour
{
        [FormerlySerializedAs("canvas")] [SerializeField] private VBJskedbfjkwebkjvrtkj WEnvjklq;
        [FormerlySerializedAs("levelsDatabase")] [SerializeField] private BNjkrengjk2 bNjkrengjk2;
        [FormerlySerializedAs("soundManager")] [SerializeField] private OPakolnsadq oPakolnsadq;

        private readonly BNKLasdnlkrhiouq _bnkLasdnlkrhiouq = BNKLasdnlkrhiouq.WQcvrety;

        private void Start()
        {
                Application.targetFrameRate = 60;
                
                DontDestroyOnLoad(this);
                
                _bnkLasdnlkrhiouq.WSlqweojpgo5(WEnvjklq);
                _bnkLasdnlkrhiouq.WSlqweojpgo5(bNjkrengjk2);
                _bnkLasdnlkrhiouq.WSlqweojpgo5(new BMkldnmlkOIWnoiqwe(bNjkrengjk2));
                _bnkLasdnlkrhiouq.WSlqweojpgo5(oPakolnsadq);
                
                WEnvjklq.Bootstrap(_bnkLasdnlkrhiouq);
                WEnvjklq.Load();
        }
}