//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: Diablomon.cs
//작성일: 2018.06.14
//작성자: 권기석
//내용  : 적 캐릭터 디아블로몬 구현 
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
    class Diablomon : Unit
    {
        private string _name = "디아블로몬";
        private int _hp = 1100101;
        private int _dmg = 1010011;
        private LEVEL _level = LEVEL.ULTIMATE;
        private bool _alive = true;

        public Diablomon() { }

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
    }
}
