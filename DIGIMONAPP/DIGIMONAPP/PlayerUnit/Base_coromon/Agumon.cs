//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: Agumon.cs
//작성일: 2018.06.14
//작성자: 권기석
//내용  : 플레이어 캐릭터 Agumon 구현 
//        .+코로몬 스킬 구현방식 생각해내야함 (유닛클래스로 객체 받아와서 이 파일에서 계산 던져줄지 배틀매니저로 줄지
//          스킬사용 = 버프 형식으로 스킬 버튼을 누르고 어택을 누르면 추가데미지
//         +유닛 죽는 것 이벤트로 어떻게 구현할 지 생각
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
    class Agumon : Unit
    {
        private string _name = "아구몬";
        private int _hp = 70;
        private int _dmg = 8;
        private LEVEL _level = LEVEL.ROOKIE;
        private bool _alive = true;

        public Agumon() { }

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
