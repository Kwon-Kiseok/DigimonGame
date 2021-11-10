//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: Unit.cs
//작성일: 2018.06.10
//작성자: 권기석
//내용  : 디지몬게임에 유닛에 부모가 될 클래스 Unit 을 DLL로 생성
//
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System;


namespace DIGIMON_DLL
{
    /// <summary>
    /// 치명타 피격 인터페이스 생성 
    /// 플레이어 캐릭터가 아닌 적 캐릭터에만 들어가도록 EnemyUnit 소속 유닛 클래스에만 다중상속 해줌
    /// </summary>
    public interface ICritical_HIT 
    {
        int Critical_Hit();
    }

    public enum LEVEL { BABY,ROOKIE,CHAMPION,PERFECT,ULTIMATE };   //유년기, 성장기, 성숙기, 완전체 ,궁극체
    public enum UNITTYPE { PLAYER_CHAR, ENEMY_CHAR, DEFAULT }; 

    public class Unit
    {
        private string _name = "";
        private int _hp = 0;
        private int _dmg = 0;
        private LEVEL _level = LEVEL.BABY;
        private bool _alive = true;

        protected UNITTYPE unitType = UNITTYPE.DEFAULT;

        public Unit() { }

        /// <summary>
        /// private로 은닉되어 있는 Unit의 상속되어야 할 데이터들 
        /// 가상함수로 상속받는 파생클래스들에서 접근 가능하도록 디자인
        /// 본래 프로퍼티로 해줄 예정이었지만 윈폼에서의 사용이 어려워서 
        /// 가상함수로 넘겨주고 파생클래스에서 오버라이딩 하는 방식으로 전환
        /// 그러면서 특정 조건을 만족할 시 분기점 추가 등의 수정이 더 쉬워짐
        /// </summary>
        /// <returns></returns>
        public virtual string NAME()
        {
            return _name;
        }
        public virtual int HP()
        {
            return _hp;
        }
        public virtual int DMG()
        {
            return _dmg;
        }
        public virtual LEVEL GETLEVEL()
        {
            return _level;
        }


        /// <summary>
        /// 유닛의 타입 프로퍼티로 받아와서 팩토리에서 
        /// 유닛 타입을 지정해줌
        /// </summary>
        public UNITTYPE GetUNITTYPE
        {
            set { unitType = value; }
            get { return unitType; }
        }

        public virtual int HIT(int DMG)
        {
            if(_hp > 0)
            {
                _hp -= DMG;
                return _hp;
            }
            return 0;
        }
        public virtual bool Dead()
        {
            return _alive;
        }
    }
}
