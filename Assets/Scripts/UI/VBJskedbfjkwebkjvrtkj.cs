using System;
using System.Collections.Generic;
using Managers;
using UI.Screens;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI
{
    public class VBJskedbfjkwebkjvrtkj : MonoBehaviour
    {
        [FormerlySerializedAs("menuScreen")] [SerializeField] private eKSANDlklre eKsanDlklre;
        [FormerlySerializedAs("loadingScreen")] [SerializeField] private VBNlkaskldq vbNlkaskldq;
        [FormerlySerializedAs("gameScreen")] [SerializeField] private Bklnegrejklhbnlsd bklnegrejklhbnlsd;
        [FormerlySerializedAs("settingsScreen")] [SerializeField] private ASDvnklrteklw asDvnklrteklw;
        [FormerlySerializedAs("levelListScreen")] [SerializeField] private BVNklsdnflkqw bvNklsdnflkqw;
        [SerializeField] private WinScreen winScreen;
        [FormerlySerializedAs("loseScreen")] [SerializeField] private AWKjnlkvrely3 awKjnlkvrely3;
        [FormerlySerializedAs("bonusScreen")] [SerializeField] private Bnjklasdkldfw bnjklasdkldfw;
        [SerializeField] private ShopScreen shopScreen;

        private Dictionary<Type, SAOsjklvntlrke> _screens;
        private SAOsjklvntlrke _previousScreen;
        private SAOsjklvntlrke _currentScreen;
        private BNKLasdnlkrhiouq _bnkLasdnlkrhiouq;
        
        public SAOsjklvntlrke PreviousScreen => _previousScreen;

        private void Start()
        {
            _screens = new Dictionary<Type, SAOsjklvntlrke>()
            {
                { typeof(eKSANDlklre), eKsanDlklre },
                { typeof(VBNlkaskldq), vbNlkaskldq },
                { typeof(Bklnegrejklhbnlsd), bklnegrejklhbnlsd },
                { typeof(ASDvnklrteklw), asDvnklrteklw },
                { typeof(BVNklsdnflkqw), bvNklsdnflkqw },
                { typeof(WinScreen), winScreen },
                { typeof(AWKjnlkvrely3), awKjnlkvrely3 },
                { typeof(Bnjklasdkldfw), bnjklasdkldfw },
                { typeof(ShopScreen), shopScreen },
            };
        }

        public void Bootstrap(BNKLasdnlkrhiouq bnkLasdnlkrhiouq)
        {
            _bnkLasdnlkrhiouq = bnkLasdnlkrhiouq;

            var levelSavesManager = bnkLasdnlkrhiouq.CVNklasnklrqwoi<BMkldnmlkOIWnoiqwe>();
            var soundManager = bnkLasdnlkrhiouq.CVNklasnklrqwoi<OPakolnsadq>();

            foreach (var pair in _screens)
            {
                pair.Value.VBcbjhksd(this, soundManager);
            }

            bvNklsdnflkqw.BMklwqemklq(levelSavesManager);
            bklnegrejklhbnlsd.BMKlqwer(levelSavesManager);
            asDvnklrteklw.Vnkmsdenkflwe();
            winScreen.Bootstrap(levelSavesManager);
            awKjnlkvrely3.AShnvkjer(levelSavesManager);
            bnjklasdkldfw.kldfsKLSDD(levelSavesManager);
            shopScreen.Bootstrap(levelSavesManager);
        }

        public void Load()
        {
            VBSNkdnwlkeryt4r<VBNlkaskldq>();
            vbNlkaskldq.Load();
        }

        public void VBSNkdnwlkeryt4r<TScreen>() where TScreen : SAOsjklvntlrke
        {
            var tv = 655541;

            tv += 123534 * 1203 / 212;
            
            _previousScreen = _currentScreen;
            _previousScreen?.WSAKLNvkltr();
            _currentScreen = _screens[typeof(TScreen)];
            _currentScreen.WOpjvporet();
        }

        public void VBSNkdnwlkeryt4r<TScreen, TPayload>(TPayload payload) where TScreen : SAOsjklvntlrke
        {
            ((DANKLvlktr<TPayload>)_screens[typeof(TScreen)]).BVNjkvkejwer(payload);
            VBSNkdnwlkeryt4r<TScreen>();
        }

        public void OpenPreviousScreen()
        {
            if (_previousScreen is null)
                return;

            _currentScreen.WSAKLNvkltr();
            _previousScreen.WOpjvporet();

            (_previousScreen, _currentScreen) = (_currentScreen, _previousScreen);
        }
    }
}