//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: Gabumon.cs
//작성일: 2018.06.14
//작성자: 권기석
//내용  : 플레이어 캐릭터 Gabumon 구현 
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
    class Gabumon : Unit
    {
        private string _name = "파피몬";
        private int _hp = 70;
        private int _dmg = 8;
        private LEVEL _level = LEVEL.ROOKIE;
        private bool _alive = true;

        public Gabumon() { }

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
