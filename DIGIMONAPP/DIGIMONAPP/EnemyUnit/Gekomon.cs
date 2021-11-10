//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: Gekomon.cs
//작성일: 2018.06.10
//작성자: 권기석
//내용  : 적 캐릭터 Gekomon 구현 
//        적 공격방식 생각
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
    class Gekomon : Unit , ICritical_HIT
    {
        private string _name = "개굴몬";
        private int _hp = 70;
        private int _dmg = 2;
        private LEVEL _level = LEVEL.ROOKIE;
        private bool _alive = true;

        public Gekomon() { }

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
            if(HP() <= 0)
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