//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: Etemon.cs
//작성일: 2018.06.13
//작성자: 권기석
//내용  : 적 캐릭터 에테몬 구현 
//        
//         
//       
//
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIGIMON_DLL;


namespace DIGIMONAPP
{
    class Etemon : Unit , ICritical_HIT
    {
        private string _name = "에테몬";
        private int _hp = 140;
        private int _dmg = 10;
        private LEVEL _level = LEVEL.PERFECT;
        private bool _alive = true;

        public Etemon() { }

        public override string NAME()
        {
            return _name;
        }
        public override int HP()
        {
            return _hp;
        }
        public override int DMG()
        {
            return _dmg;
        }
        public override LEVEL GETLEVEL()
        {
            return _level;
        }
        public override int HIT(int DMG)
        {
            if (_hp > 0)
            {
                _hp -= DMG;
                return _hp;
            }
            return 0;
        }
        public override bool Dead()
        {
            if (HP() <= 0)
            {
                return _alive = false;
            }
            return _alive;
        }
        public int Critical_Hit()
        {
            _hp -= 10;
            return _hp;
        }
    }
}
