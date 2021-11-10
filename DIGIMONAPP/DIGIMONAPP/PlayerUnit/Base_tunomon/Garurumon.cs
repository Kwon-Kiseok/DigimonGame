//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: Garurumon.cs
//작성일: 2018.06.14
//작성자: 권기석
//내용  : 플레이어 캐릭터 Garurumon 구현 
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
    class Garurumon : Unit
    {
        private string _name = "가루몬";
        private int _hp = 110;
        private int _dmg = 10;
        private LEVEL _level = LEVEL.CHAMPION;
        private bool _alive = true;

        public Garurumon() { }

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
